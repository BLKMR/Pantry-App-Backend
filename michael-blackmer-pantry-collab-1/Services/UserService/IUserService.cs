using michael_blackmer_pantry_collab_1.Models;

namespace michael_blackmer_pantry_collab_1.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();

        Task AddUser(User user);
    }
}
