using LoginService.Domain.Models.Request;
using LoginService.Domain.Models.Response;
using LoginService.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LoginService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IUserLoginService _userLoginService;

        public LoginController(IUserLoginService userLoginService)
        {
            _userLoginService = userLoginService;
        }

        [HttpPost("Login")]
        public ActionResult<LoginResponse> Login(LoginRequest request)
        {
            return Ok();
        }

        [HttpPost("SignUp")]
        public ActionResult SignUp(SignUpRequest request)
        {
            try
            {
                return Ok(_userLoginService.RegisterUser(request));
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("Date")]
        public ActionResult<DateTime> GetDate()
        {
            return Ok(DateTime.Now);
        }
    }
}
