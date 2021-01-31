using LoginService.Domain.Models.Request;
using LoginService.Domain.Models.Response;
using System.Threading.Tasks;

namespace LoginService.Services.Interfaces
{
    public interface IUserLoginService
    {
        LoginResponse LoginRequest(LoginRequest request);
        Task RegisterUser(SignUpRequest request);
    }
}
