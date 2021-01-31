using LoginService.Domain.Models;
using LoginService.Domain.Repositories.Base.Interfaces;

namespace LoginService.Domain.Repositories.Interfaces
{
    public interface IUserLoginRepository : IRepository<User>
    {
        bool FindByLogin(string login, byte[] password);
    }
}
