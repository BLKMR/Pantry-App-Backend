using michael_blackmer_pantry_collab_1.Models;
using michael_blackmer_pantry_collab_1.Services.UserAccountServices;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace michael_blackmer_pantry_collab_1.Controllers
{
    [EnableCors("localhost")]
    [Route("api/UserAccount")]
    [ApiController]
    public class UserAccountController : ControllerBase
    {
        private readonly IUserAccountService _userAccountService;


        public UserAccountController(IUserAccountService accountService)
        {
            _userAccountService = accountService;
        }


        //GET ALL ACCOUNTS
        [HttpGet]
        public async Task<ActionResult<List<UserAccount>>> GetAllUserAccounts(int familyId)
        {
            return await _userAccountService.GetAllUserAccounts(familyId);
        }
    }
}





       