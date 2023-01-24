using michael_blackmer_pantry_collab_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Security.Principal;

namespace michael_blackmer_pantry_collab_1.Services.UserService
{
    public class UserService : IUserService
    {

        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        //GetAllAccounts
        public async Task<List<User>> GetAllUsers()
        {
            var user = await _context.Users.ToListAsync();
            return user;
        }

        public async Task<User?> GetUserById(int id)
        {
            var account = await _context.Users.FindAsync(id);
            if (account is null)
            {
                throw new Exception("Account not found");
            }

            return account;
        }

        public async Task<User> GetUserByUsernameAndPassword(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Name == username && u.Password == password);
            if (user != null)
            { 
                return user;
            }

            throw new Exception("Email/Password incorrect");
        }


        //Create a Family
        public async Task AddUser(User user)
        {

            var userExists = await _context.Users.FirstOrDefaultAsync(u => u.Name == user.Name);

            if (userExists is null) 
            {
                var linkedFamily = await _context.Families
                .Where(f => f.Name == user.FamilyName)
                .Include(f => f.Users)
                .FirstOrDefaultAsync();

                var newUser = new User
                {
                    Name = user.Name,
                    Id = user.Id,
                    Password = user.Password,
                    FamilyName = user.FamilyName,
                    FamilyId = linkedFamily.Id,
                };

                _context.Users.Add(newUser);
                await _context.SaveChangesAsync();
                return;

            }

            throw new Exception("Account name used");                     

        }
    }
}


