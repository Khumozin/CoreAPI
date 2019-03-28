using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<MainMember> MainMember { get; set; }

        public DbSet<Dependant> Dependant { get; set; }
        public DbSet<Package> Package { get; set; }
    }
}