using LoginService.Domain.Context;
using LoginService.Domain.Models;
using LoginService.Domain.Repositories.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoginService.Domain.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DBContext _context;

        public Repository(DBContext context)
        {
            _context = context;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public virtual async Task<T> FindByIdAsync(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public virtual async Task InsertAsync(T entity)
        {
            await _context.AddAsync(entity);
            Commit();
        }

        public virtual void Update(T entity)
        {
            entity.ModifiedAt = DateTime.Now;
            _context.Update(entity);
            Commit();
        }

        public virtual async Task RemoveAsync(Guid id)
        {
            var entity = await FindByIdAsync(id);
            entity.FlagActive = false;
            Update(entity);
        }

        public virtual void Remove(T entity)
        {
            entity.FlagActive = false;
            Update(entity);
        }

        public virtual async Task HardRemoveAsync(Guid id)
        {
            var entity = await FindByIdAsync(id);
            _context.Remove(entity);
            Commit();
        }

        public virtual void HardRemove(T entity)
        {
            _context.Remove(entity);
            Commit();
        }

        private void Commit()
        {
            _context.SaveChanges();
        }
    }
}
