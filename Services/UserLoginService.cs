using LoginService.Domain.Models.Request;
using LoginService.Domain.Models.Response;
using LoginService.Domain.Repositories.Interfaces;
using LoginService.Services.Interfaces;
using System.Threading.Tasks;

namespace LoginService.Services
{
    public class UserLoginService : IUserLoginService
    {
        private readonly IUserLoginRepository _userLoginRepository;

        public UserLoginService(IUserLoginRepository userLoginRepository)
        {
            _userLoginRepository = userLoginRepository;
        }

        public LoginResponse LoginRequest(LoginRequest request)
        {
            var x = _userLoginRepository.FindByLogin(request.Login, request.Password);

            return new LoginResponse();
        }

        public async Task RegisterUser(SignUpRequest request)
        {

        }
    }
}
