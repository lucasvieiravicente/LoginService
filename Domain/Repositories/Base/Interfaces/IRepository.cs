using LoginService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoginService.Domain.Repositories.Base.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        Task<T> FindByIdAsync(Guid id);
        Task InsertAsync(T entity);
        void Update(T entity);
        Task RemoveAsync(Guid id);
        void Remove(T entity);
        Task HardRemoveAsync(Guid id);
        void HardRemove(T entity);
    }
}
