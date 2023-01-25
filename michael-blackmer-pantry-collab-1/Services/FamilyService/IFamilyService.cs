using michael_blackmer_pantry_collab_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace michael_blackmer_pantry_collab_1.Services.FamilyService
   
{
    public interface IFamilyService
    {
        Task<List<Family>> GetAllFamilies();

        Task<Family?> GetFamilyByName(string familyName);

        Task CreateFamily(Family family);
    }
}
