using LoginService.Domain.Context;
using LoginService.Domain.Models;
using LoginService.Domain.Repositories.Base;
using LoginService.Domain.Repositories.Interfaces;

namespace LoginService.Domain.Repositories
{
    public class UserLoginRepository : Repository<User>, IUserLoginRepository
    {
        public UserLoginRepository(DBContext context) : base(context)
        {
        }
    }
}
