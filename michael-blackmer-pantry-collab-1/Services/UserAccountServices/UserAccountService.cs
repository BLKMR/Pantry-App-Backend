using michael_blackmer_pantry_collab_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace michael_blackmer_pantry_collab_1.Services.UserAccountServices
{
    public class UserAccountService : IUserAccountService
    {

        private readonly DataContext _context;

        public UserAccountService(DataContext context)
        {
            _context = context;
        }


        //Get All Accounts
        public async Task<List<UserAccount>> GetAllUserAccounts(int familyId)
        {
            var userAccounts = await _context.UserAccounts
                .Where(a => a.FamilyAccount.Id == familyId)
                .ToListAsync();

            return userAccounts;
        }

        public async Task<UserAccount> GetUserByUsername(string userName)
        {
            var userAccount = await _context.UserAccounts
                .FirstOrDefaultAsync(a => a.UserName == userName);
            if (userAccount == null)
            {
                throw new Exception("Account not found");
            }

            return userAccount;
        }


        public async Task<UserAccount> GetUserByUsernameAndPassword(string userName, string password)
        {
            var userAccount = await _context.UserAccounts.FirstOrDefaultAsync(userAccount => userAccount.UserName == userName && userAccount.Password == password);
            if (userAccount != null)
                return userAccount;

            throw new Exception("Username taken");
        }


    }
}
