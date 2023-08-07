using Microsoft.AspNetCore.Mvc;
using miscellaneous.Services.UserService;

namespace miscellaneous.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //private readonly ILogger _logger;

        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet(Name = "GetUSers")]
        public async Task<IActionResult> Get()
        {
            var users = await _userService.GetAll();
            if (users.Any())
            {
                return Ok(users);
            }
            else
            {
                return NotFound();
            }
        }


    }
}
