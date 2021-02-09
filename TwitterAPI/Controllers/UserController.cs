using Microsoft.AspNetCore.Mvc;
using TwitterAPI.Core.UserManagement;

namespace TwitterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        [Route("current")]
        public ActionResult<UserDto> GetCurrentUser()
        {
            var currentUser = userService.GetCurrentUser();
            if (currentUser != null)
            {
                return Ok(currentUser);
            }
            return NotFound();
        }
    }
}
