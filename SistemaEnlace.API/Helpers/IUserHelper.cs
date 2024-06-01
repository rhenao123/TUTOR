using SistemaEnlace.Shared.Entities;
using Microsoft.AspNetCore.Identity;
using SistemaEnlace.Shared.DTOs;

namespace SistemaEnlace.API.Helpers
{
    public interface IUserHelper

    {

        Task<User> GetUserAsync(string email);
        Task<IdentityResult> AdduserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginDTO model);

        Task LogoutAsync();

        //Editar usuario
        Task<IdentityResult> ChangePasswordAsync(User user, string currentPassword, string newPassword);

        Task<IdentityResult> UpdateUserAsync(User user);

        Task<User> GetUserAsync(Guid userId);


    }
}