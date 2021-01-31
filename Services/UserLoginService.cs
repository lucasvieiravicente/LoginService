using AutoMapper;
using LoginService.Domain.Models;
using LoginService.Domain.Models.Request;
using LoginService.Domain.Models.Response;
using LoginService.Domain.Repositories.Interfaces;
using LoginService.Services.Interfaces;
using LoginService.Utils;
using System.Threading.Tasks;

namespace LoginService.Services
{
    public class UserLoginService : IUserLoginService
    {
        private readonly IUserLoginRepository _userLoginRepository;
        private readonly IMapper _mapper;

        public UserLoginService(IUserLoginRepository userLoginRepository, IMapper mapper)
        {
            _userLoginRepository = userLoginRepository;
            _mapper = mapper;
        }

        public LoginResponse LoginRequest(LoginRequest request)
        {
            var response = new LoginResponse();
            var hasRegister = _userLoginRepository.FindByLogin(request.Login, HashUtil.HashPassword(request.Password));

            if (hasRegister)
                response.JwtResponse = TokenUtil.GenerateTokenJWT();
            else
                return null;

            return response;
        }

        public async Task RegisterUser(SignUpRequest request)
        {
            await _userLoginRepository.InsertAsync(_mapper.Map<User>(request));
        }
    }
}
