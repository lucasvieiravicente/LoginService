using LoginService.Domain.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace LoginService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public void Post(LoginRequest request)
        {
        }
    }
}
