using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController(
    SignInManager<User> signInManager,
    UserManager<User> userManager,
    IEmailSender emailSender) : ControllerBase
{
    private readonly IEmailSender _emailSender = emailSender;
    private readonly SignInManager<User> _signInManager = signInManager;
    private readonly UserManager<User> _userManager = userManager;

    [HttpPost("register")]
    public async Task<ActionResult> Register(RegisterModel model)
    {
        var user = new User
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            UserName = model.Email,
            PasswordHash = model.Password
        };

        var result = await _userManager.CreateAsync(user, model.Password!);

        if (!result.Succeeded)
            return Unauthorized(result.Errors);

        await _userManager.AddToRoleAsync(user, "Staff Member");

        await SendConfirmationEmail(user);

        return Ok("Register successful!");
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login(LoginModel model)
    {
        var user = await _userManager.FindByEmailAsync(model.Email!);
        if (user == null)
            return Unauthorized(new { message = "No user with given e-mail address." });

        var result = await _signInManager.PasswordSignInAsync(user, model.Password!, false, false);

        if (result.Succeeded)
            return Ok("Login successful!");
        return Unauthorized(result.IsNotAllowed
            ? "Before you sign in you have to confirm your email."
            : "Login attempt failed!");
    }

    [HttpPost("logout")]
    public async Task<ActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return Ok("Logout successful!");
    }

    [HttpGet("confirmEmail")]
    public async Task<ActionResult> ConfirmEmail(string? userId, string? token)
    {
        if (userId == null || token == null)
            return BadRequest("Invalid email confirmation request.");

        var user = await _userManager.FindByIdAsync(userId);

        if (user == null)
            return NotFound("User doesn't exist.");

        var result = await _userManager.ConfirmEmailAsync(user, token);

        if (!result.Succeeded)
            return Unauthorized(result.Errors);

        return Ok("Email confirmed! Now you can go back to PMS and log in.");
    }

    [HttpPost("resendConfirmationEmail")]
    public async Task<ActionResult> ResendConfirmationEmail(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
            return NotFound("User doesn't exist.");

        SendConfirmationEmail(user);
        return Ok("Email confirmation link sent. Check your inbox.");
    }

    private async Task SendConfirmationEmail(User user)
    {
        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        var confirmationLink =
            Url.Action(
                nameof(ConfirmEmail),
                "Account",
                new { userId = user.Id, token },
                Request.Scheme);

        await _emailSender.SendEmailAsync(user.Email!, "Email confirmation",
            $"Please confirm your account by clicking this link: <a href={confirmationLink}>link</a>");
    }
}