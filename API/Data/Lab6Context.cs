using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Lab6Context : DbContext
    {
        public Lab6Context(DbContextOptions<Lab6Context> options) : base(options)
        {
            
        }

        public DbSet<API.Models.Sock> Sock { get; set; } = default!;
        public DbSet<API.Models.SockManufacturer> SockManufacturer { get; set; } = default!;
        public DbSet<API.Models.SockShops> SockShops { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            
        }
    }
}