using michael_blackmer_pantry_collab_1.Models;

namespace michael_blackmer_pantry_collab_1.Services.FamilyAccountServices
{
    public interface IFamilyAccountService
    {
        Task<List<FamilyAccount>> GetAllFamilyAccounts();
    
    }
}