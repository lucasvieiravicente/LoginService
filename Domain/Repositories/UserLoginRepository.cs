using LoginService.Domain.Context;
using LoginService.Domain.Models;
using LoginService.Domain.Repositories.Base;
using LoginService.Domain.Repositories.Interfaces;
using System.Linq;

namespace LoginService.Domain.Repositories
{
    public class UserLoginRepository : Repository<User>, IUserLoginRepository
    {
        private DBContext _context;

        public UserLoginRepository(DBContext context) : base(context)
        {
            _context = context;
        }

        public User FindByLogin(string login, string password)
        {
            return _context.Set<User>()
                           .Where(x => x.Login.Equals(login) && x.Password.Equals(password))
                           .FirstOrDefault();
        }
    }
}
