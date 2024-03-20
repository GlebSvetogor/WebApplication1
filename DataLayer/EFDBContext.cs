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
            optionsBuilder.UseSqlServer("Data Source=(local); Database=WebApp1; Persist Security Info=false; User ID='sa'; Password='sa'; MultipleActiveResultSets=True; Trusted_Connection=False; TrustServerCertificate=True");

            return new EFDBContext(optionsBuilder.Options);
        }
    }

}


