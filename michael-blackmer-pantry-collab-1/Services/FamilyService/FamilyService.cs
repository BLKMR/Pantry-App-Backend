using michael_blackmer_pantry_collab_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Security.Principal;

namespace michael_blackmer_pantry_collab_1.Services.FamilyService
{
    public class FamilyService : IFamilyService
    {
        private readonly DataContext _context;

        public FamilyService(DataContext context)
        {
            _context = context;
        }

        //GetAllFamilies
        public async Task<List<Family>> GetAllFamilies()
        {
            var family = await _context.Families.ToListAsync();
            return family;
        }

        public async Task<Family?> GetFamilyByName(string familyName)
        {
            var family = await _context.Families.FirstOrDefaultAsync(f => f.Name == familyName);
            return family;
            
        }


        //Create a Family

        public async Task CreateFamily(Family family)
        {
            var familyExists = await _context.Families.FirstOrDefaultAsync(f => f.Name == family.Name);
            if (familyExists is null) 
            {
                var newFamily = new Family
                {
                    Id = family.Id,
                    Name = family.Name,
                    Pantry = family.Pantry,

                };
                _context.Families.Add(newFamily);
                await _context.SaveChangesAsync();
                return;
            }

            throw new Exception("Family name taken");


        }


    }
}
