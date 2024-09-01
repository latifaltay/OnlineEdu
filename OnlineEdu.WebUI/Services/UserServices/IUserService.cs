using Microsoft.AspNetCore.Identity;
using OnlineEdu.WebUI.DTOs.UserDtos;
using System.Globalization;

namespace OnlineEdu.WebUI.Services.UserServices
{
    public interface IUserService
    {
        Task<IdentityResult> CreteUserAsync(UserRegisterDto userRegisterDto);
        Task<bool> LoginAsync(UserLoginDto userLoginDto);
        Task<bool> CreateRoleAsync(UserRoleDto userRoleDto);
        Task<bool> AssignRoleAsync(AssignRoleDto assignRoleDto);
        Task<bool> LogoutAsync();

    }
}
