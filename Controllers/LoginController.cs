using LoginService.Domain.Models.Request;
using LoginService.Domain.Models.Response;
using LoginService.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
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

        [AllowAnonymous]
        [HttpPost("Login")]
        public ActionResult<LoginResponse> Login(LoginRequest request)
        {
            var result = _userLoginService.LoginRequest(request);

            if (result != null)
                return Ok(result);
            else
                return NotFound("Nenhum registro encontrado, verifique seu login e senha");
        }

        [AllowAnonymous]
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

        [Authorize()]
        [HttpGet("Date")]
        public ActionResult<DateTime> GetDate()
        {
            return Ok(DateTime.Now);
        }
    }
}
