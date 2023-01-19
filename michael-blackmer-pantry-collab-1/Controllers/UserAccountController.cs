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


        [HttpGet("{userName}")]
        public async Task<ActionResult<UserAccount>> GetUserByUsername(string userName)
        {
            try
            {
                var result = await _userAccountService.GetUserByUsername(userName);
                return Ok(result);
            }
            catch (Exception)
            {

                return NotFound("Account not found.");
            }
        }

        [HttpGet("{userName}/{password}")]
        public async Task<ActionResult<UserAccount>> GetUserbyUsernameAndPassword(string userName, string password)
        {
            try
            {
                var result = await _userAccountService.GetUserByUsernameAndPassword(userName, password);
                return Ok(result);
            }
            catch (Exception)
            {
                return NotFound("Username/Password Incorrect");
            }


        }
    }
}





       