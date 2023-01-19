using michael_blackmer_pantry_collab_1.Models;

namespace michael_blackmer_pantry_collab_1.Services.UserAccountServices
{
    public interface IUserAccountService
    {
        Task<List<UserAccount>> GetAllUserAccounts(int familyId);
        Task<UserAccount> GetUserByUsername(string userName);

        Task<UserAccount> GetUserByUsernameAndPassword(string userName, string password);

    }
}
