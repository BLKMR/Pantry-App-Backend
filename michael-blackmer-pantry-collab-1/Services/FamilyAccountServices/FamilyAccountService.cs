using michael_blackmer_pantry_collab_1.Models;
using Microsoft.EntityFrameworkCore;

namespace michael_blackmer_pantry_collab_1.Services.FamilyAccountServices
{
    public class FamilyAccountService : IFamilyAccountService
    {
    
        private readonly DataContext _context;

        public FamilyAccountService(DataContext context)
        {
            _context = context;
        }


        //Get All Accounts
        public async Task<List<FamilyAccount>> GetAllFamilyAccounts()
        {
            var familyAccounts = await _context.FamilyAccounts.ToListAsync();
            return familyAccounts;
        }


    }
}
