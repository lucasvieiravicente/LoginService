using LoginService.Domain.Models;
using LoginService.Domain.Repositories.Base.Interfaces;

namespace LoginService.Domain.Repositories.Interfaces
{
    public interface IUserLoginRepository : IRepository<User>
    {
        User FindByLogin(string login, string password);
    }
}
