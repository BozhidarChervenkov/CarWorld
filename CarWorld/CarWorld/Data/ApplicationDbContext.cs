namespace CarWorld.Data
{   
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using CarWorld.Models;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Make> Makes { get; set; }

        public DbSet<Model> Models { get; set; }

        public DbSet<Picture> Pictures { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<BodyType> BodyTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Picture>()
                .HasOne(p => p.Car)
                .WithMany(c=>c.Pictures)
                .HasForeignKey(p => p.CarId);
        }
    }
}
