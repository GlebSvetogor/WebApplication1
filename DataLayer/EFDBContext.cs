using DataLayer.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataLayer
{
    public class EFDBContext : DbContext
    {
        public DbSet<Dir> Directory { get; set; }
        public DbSet<Material> Material { get; set; }

        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer("");

        //protected override void OnModelCreating(ModelBuilder modelBuilder) { }

    }

    

    public class EFDBContextFactory : IDesignTimeDbContextFactory<EFDBContext>
    {
        public EFDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder  = new DbContextOptionsBuilder<EFDBContext>();
            optionsBuilder.UseSqlServer("Server=(localdb);Database=WebApp1;Trusted_Connection=True");

            return new EFDBContext(optionsBuilder.Options);
        }
    }

}


