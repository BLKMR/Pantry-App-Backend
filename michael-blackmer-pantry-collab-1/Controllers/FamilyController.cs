
using michael_blackmer_pantry_collab_1.Models;
using michael_blackmer_pantry_collab_1.Services.FamilyService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace michael_blackmer_pantry_collab_1.Controllers
{
    [EnableCors("localhost")]
    [Route("api/Families")]
    [ApiController]
    public class FamilyController : ControllerBase
    {
        private readonly IFamilyService _familyService;

        public FamilyController(IFamilyService familyService)
        {
            _familyService = familyService;
        }


        [HttpGet]
        public async Task<ActionResult<List<Family>>> GetAllFamilies()
        {
            return await _familyService.GetAllFamilies();
        }




        [HttpPost]
        public async Task<ActionResult> CreateFamily(Family family)
        {
            await _familyService.CreateFamily(family);
            return Ok(family);
        }
    }
}
