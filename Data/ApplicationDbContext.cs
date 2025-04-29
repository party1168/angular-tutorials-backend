using Microsoft.EntityFrameworkCore;
using angular_tutorials_backend.Models;

namespace angular_tutorials_backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; } = null!;
    }
}