using Microsoft.EntityFrameworkCore;
using ApiJuan.Models;

namespace ApiJuan.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
    }
}
