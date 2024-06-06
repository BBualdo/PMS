using System.Text;
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

        if (user.EmailConfirmed)
            return NoContent();

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
            // Don't notify that user doesn't exist
            return NoContent();

        await SendConfirmationEmail(user);
        return Ok("Email confirmation link sent. Check your inbox.");
    }

    [HttpPost("forgotPassword")]
    public async Task<ActionResult> ForgotPassword(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
            // Don't notify that user doesn't exist
            return NoContent();

        await SendPasswordRecoveryEmail(user);
        return Ok("Password reset email sent. Please check your inbox.");
    }

    [HttpPost("resetPassword")]
    public async Task<ActionResult> ResetPassword(
        [FromQuery] string token,
        [FromBody] PasswordResetModel model)
    {
        var user = await _userManager.FindByEmailAsync(model.Email!);
        if (user == null)
            return BadRequest("Changing password failed.");

        var result = await _userManager.ResetPasswordAsync(user, token, model.NewPassword!);

        if (!result.Succeeded)
            return BadRequest(result.Errors);

        return Ok("Password has been changed!");
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

        StringBuilder template = new();
        template.Append($"<p>Hello {user.FirstName},</p>");
        template.Append("<p>Thank you for registering on Product Management System platform.</p>");
        template.Append("<p>One last step is to confirm your email. You can do that by clicking in this link:</p>");
        template.Append($"<a href={confirmationLink}>Link</a>");
        template.Append("<p>Best regards, PMS Support.</p>");

        await _emailSender.SendEmailAsync(user.Email!, "Email confirmation", template.ToString());
    }

    private async Task SendPasswordRecoveryEmail(User user)
    {
        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        var passwordRecoveryLink = $"http:localhost:4200/passwordRecovery?token={token}";

        StringBuilder template = new();
        template.Append($"<p>Hello {user.FirstName},</p>");
        template.Append("<p>Here is your link to reset your password:</p>");
        template.Append($"<a href={passwordRecoveryLink}>Link</a>");
        template.Append("<p>If you didn't ask for password recovery then just ignore that message.</p>");
        template.Append("<p>Best regards, PMS Support.</p>");

        await _emailSender.SendEmailAsync(user.Email!, "Password reset", template.ToString());
    }
}