using API.Services.DTOs;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API.Services;

public class UsersService(UserManager<User> userManager) : IUsersService
{
    private readonly UserManager<User> _userManager = userManager;

    public async Task<PaginatedUsers> GetUsersAsync(int page, int pageSize)
    {
        var users = await _userManager.Users.ToListAsync();
        var totalPages = (int)Math.Ceiling((double)users.Count / pageSize);
        var paginatedUsers = users
            .Skip((page - 1) * pageSize);

        return new PaginatedUsers
        {
            Total = totalPages,
            Users = paginatedUsers
        };
    }

    public async Task<User> GetUserByIdAsync(string id)
    {
        return await _userManager.FindByIdAsync(id);
    }

    public async Task<bool> AddUserAsync(RegisterModel model)
    {
        var user = new User
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            UserName = model.Email
        };

        var result = await _userManager.CreateAsync(user, model.Password);

        return result.Succeeded;
    }

    public async Task DeleteUserAsync(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        await _userManager.DeleteAsync(user);
    }

    public async Task<bool> UpdateUserAsync(string id, UpdateUserModel model)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user == null) return false;

        user.FirstName = model.FirstName;
        user.LastName = model.LastName;
        user.Email = model.Email;

        var result = await _userManager.UpdateAsync(user);

        return result.Succeeded;
    }
}