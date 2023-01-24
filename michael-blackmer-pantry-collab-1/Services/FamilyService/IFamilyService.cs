using michael_blackmer_pantry_collab_1.Models;

namespace michael_blackmer_pantry_collab_1.Services.FamilyService
   
{
    public interface IFamilyService
    {
        Task<List<Family>> GetAllFamilies();


        Task CreateFamily(Family family);
    }
}
