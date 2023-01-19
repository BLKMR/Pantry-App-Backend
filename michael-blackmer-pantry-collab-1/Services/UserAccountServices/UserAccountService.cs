using michael_blackmer_pantry_collab_1.Models;
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


    }
}
