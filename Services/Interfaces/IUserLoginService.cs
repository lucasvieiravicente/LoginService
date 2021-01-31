using LoginService.Domain.Models.Request;
using LoginService.Domain.Models.Response;

namespace LoginService.Services.Interfaces
{
    public interface IUserLoginService
    {
        LoginResponse LoginRequest(LoginRequest request)
    }
}
