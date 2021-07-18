namespace CarWorld.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;   

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

        public DbSet<Vote> Votes { get; set; }

        public DbSet<Show> Shows { get; set; }

        public DbSet<ShowPicture> ShowPictures { get; set; }

        public DbSet<Video> Videos { get; set; }

        public DbSet<MainComment> MainComments { get; set; }

        public DbSet<SubComment> SubComments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Picture>()
                .HasOne(p => p.Car)
                .WithMany(c=>c.Pictures)
                .HasForeignKey(p => p.CarId);

            builder.Entity<Video>()
                .HasOne(v => v.Show)
                .WithMany(s => s.Videos)
                .HasForeignKey(v => v.ShowId);

            builder.Entity<Vote>()
                .HasOne(v => v.Car)
                .WithMany(c => c.Votes)
                .HasForeignKey(v=>v.CarId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
