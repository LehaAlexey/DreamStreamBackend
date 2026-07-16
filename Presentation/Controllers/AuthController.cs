using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register()
        { 
            throw new System.NotImplementedException();
        }

        [HttpPost("login")]
        public IActionResult Login()
        {
            throw new System.NotImplementedException();
        }
    }
}
