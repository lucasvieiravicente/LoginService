using AutoMapper;
using LoginService.Domain.Models;
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
        private readonly IMapper _mapper;

        public UserLoginService(IUserLoginRepository userLoginRepository, IMapper mapper)
        {
            _userLoginRepository = userLoginRepository;
            _mapper = mapper;
        }

        public LoginResponse LoginRequest(LoginRequest request)
        {
            var x = _userLoginRepository.FindByLogin(request.Login, request.Password);

            return new LoginResponse();
        }

        public async Task RegisterUser(SignUpRequest request)
        {
            var user = _mapper.Map<User>(request);
            await _userLoginRepository.InsertAsync(user);
        }
    }
}
