using LoginService.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginService.Domain.Context
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasIndex(x => x.Login).IsUnique();
        }
    }
}
