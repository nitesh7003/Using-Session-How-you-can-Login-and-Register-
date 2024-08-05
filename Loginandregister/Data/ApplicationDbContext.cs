using Loginandregister.Models;
using Microsoft.EntityFrameworkCore;

namespace Loginandregister.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
               : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
