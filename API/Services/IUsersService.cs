using API.Services.DTOs;
using Data.Models;

namespace API.Services;

public interface IUsersService
{
    Task<PaginatedUsers> GetUsersAsync(int page, int pageSize);
    Task<User> GetUserByIdAsync(string id);
    Task<bool> AddUserAsync(RegisterModel model);
    Task<bool> UpdateUserAsync(string id, UpdateUserModel model);
    Task DeleteUserAsync(string id);
}