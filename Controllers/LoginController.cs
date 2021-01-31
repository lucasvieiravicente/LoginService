using LoginService.Domain.Models.Request;
using LoginService.Domain.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace LoginService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost("Login")]
        public ActionResult<LoginResponse> Login(LoginRequest request)
        {
            return Ok();
        }

        [HttpPost("SignUp")]
        public ActionResult<LoginResponse> SignUp(SignUpRequest request)
        {
            return Ok();
        }
    }
}
