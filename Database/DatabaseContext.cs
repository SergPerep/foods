using foods.Model;
using Microsoft.EntityFrameworkCore;

namespace foods.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }
    }
}
