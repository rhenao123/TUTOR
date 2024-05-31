using SistemaEnlace.API.Helpers;
using SistemaEnlace.Shared.Entities;
using SistemaEnlace.Shared.Enums;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Azure.Identity;
using Azure;
namespace SistemaEnlace.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }



        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckfundacionAsync();
            await CheckRolesAsync();
            await CheckUserAsync("6666", "HENAO", "Admin","henaito123@gmail.com","123", "Cr 44 9996", UserType.Admin);




        }

        private async Task CheckRolesAsync()
        {
            await _userHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _userHelper.CheckRoleAsync(UserType.User.ToString());
        }



        private async Task<User> CheckUserAsync(string document, string firstName, string lastName, string email, string phone, string address, UserType userType)
        {
            var user = await _userHelper.GetUserAsync(email);

            if (user == null)
            {

                user = new User
                {
                    Document = document,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    PhoneNumber = phone,
                    UserName = email,
                    Address = address,
                    UserType = userType,
                };

                await _userHelper.AdduserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, userType.ToString());
            }
            return user;
        }




        
        private async Task CheckfundacionAsync()

        {

            if (!_context.fundacions.Any())

            {

                _context.fundacions.Add(new Fundacion { Id = 1, Name = "NO ASIGNADO", Description = "BASE" });
                await _context.SaveChangesAsync();


            }
        }
        
    }
}