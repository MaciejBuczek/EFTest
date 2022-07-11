using EFTest.Models;
using Microsoft.EntityFrameworkCore;

namespace EFTest
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<TestModel> TestModels { get; set; }
    }
}
