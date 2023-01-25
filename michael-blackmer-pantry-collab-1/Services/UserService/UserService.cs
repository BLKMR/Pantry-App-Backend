using michael_blackmer_pantry_collab_1.Models;
using Microsoft.AspNetCore.Identity;
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
                var emailExists = await _context.Users.FirstOrDefaultAsync(u => u.Name == user.Name);
                if (emailExists is null)
                {

                /* I really wanted this code to work for my entity relationships but it refused due to the family context always returning nullable and not allowing me to apply a familyId to the created user :(
                var family = await _context.Families.FirstOrDefaultAsync(f => f.Name == user.FamilyName);
                   if (family != null) 
                   {
                       user.FamilyId = family.Id;
                       _context.Users.Add(user);
                       await _context.SaveChangesAsync();
                       return;
                   }
                 */
                var newUser = new User
                {
                    Id = user.Id,
                    Name = user.Name,
                    Password = user.Password,
                    FamilyName = user.FamilyName,
                };
                _context.Users.Add(newUser);
                    await _context.SaveChangesAsync();
                    return;
                }

                throw new Exception();
                }
         

            }

        }



