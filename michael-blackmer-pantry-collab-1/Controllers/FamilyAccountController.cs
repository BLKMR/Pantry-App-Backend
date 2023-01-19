using michael_blackmer_pantry_collab_1.Models;
using michael_blackmer_pantry_collab_1.Services.FamilyAccountServices;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace michael_blackmer_pantry_collab_1.Controllers
{
    [EnableCors("localhost")]
    [Route("api/FamilyAccount")]
    [ApiController]
    public class FamilyAccountController : Controller
    {
        private readonly IFamilyAccountService _familyAccountService;


        public FamilyAccountController(IFamilyAccountService familyAccountService)
        {
            _familyAccountService = familyAccountService;
        }


        //GET ALL ACCOUNTS
        [HttpGet]
        public async Task<ActionResult<List<FamilyAccount>>> GetAllFamilyAccounts()
        {
            return await _familyAccountService.GetAllFamilyAccounts();
        }
    }
}

