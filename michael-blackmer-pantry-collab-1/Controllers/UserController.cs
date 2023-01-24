using michael_blackmer_pantry_collab_1.Models;
using michael_blackmer_pantry_collab_1.Services.UserService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace michael_blackmer_pantry_collab_1.Controllers
{
    [EnableCors("localhost")]
    [Route("api/Users")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            return await _userService.GetAllUsers();
        }

        



        [HttpPost]
        public async Task<ActionResult> AddUser(User user)
        {
                await _userService.AddUser(user);
                return Ok(user);
            }

    }
}

   
