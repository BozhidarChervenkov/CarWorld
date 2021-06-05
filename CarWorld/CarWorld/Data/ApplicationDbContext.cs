namespace CarWorld.Data
{
    using CarWorld.Models;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Make> Makes { get; set; }

        public DbSet<Model> Models { get; set; }

        public DbSet<BodyType> BodyTypes { get; set; }

        public DbSet<Picture> Pictures { get; set; }

        public DbSet<CarPicture> CarPictures { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CarPicture>()
                .HasKey(cp => new
                {
                    cp.CarId,
                    cp.PictureId
                });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        
    }
}
