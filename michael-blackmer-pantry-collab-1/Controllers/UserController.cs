using michael_blackmer_pantry_collab_1.Models;
using michael_blackmer_pantry_collab_1.Services.UserService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

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

        [HttpGet("{username}/{password}")]
        public async Task<ActionResult<User>> GetUserByUsernameAndPassword(string username, string password)
        {
            return await _userService.GetUserByUsernameAndPassword(username, password);
        }



        [HttpPost]
        public async Task<ActionResult> AddUser(User user)
        {
            try
            {
                await _userService.AddUser(user);
                return Ok();
            }
            catch (Exception)
            {
                return Conflict();
            }
        }

    }
}

   
