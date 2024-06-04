using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController(SignInManager<User> signInManager, UserManager<User> userManager) : ControllerBase
{
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

        await _userManager.AddToRoleAsync(user, "Staff Member");

        var result = await _userManager.CreateAsync(user, model.Password);

        if (result.Succeeded) return Ok("Register successful!");

        return Unauthorized(result.Errors);
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login(LoginModel model)
    {
        var user = await _userManager.FindByEmailAsync(model.Email);
        if (user == null) return Unauthorized(new { message = "No user with given e-mail address." });

        var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

        if (result.Succeeded) return Ok("Login successful!");

        return Unauthorized("Login attempt failed!");
    }

    [HttpPost("logout")]
    public async Task<ActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return Ok("Logout successful!");
    }
}