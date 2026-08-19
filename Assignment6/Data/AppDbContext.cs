using Microsoft.EntityFrameworkCore;
using Assignment_3.Models;
using Assignment6.Models;
namespace Assignment6.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //table
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<User> user { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);

                entity.Property(u => u.name)
                .IsRequired()
                .HasMaxLength(100);


                entity.Property(u => u.email)
                            .IsRequired()
                            .HasMaxLength(150);


            }

            );

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.HasKey(u => u.Id);

                entity.Property(t => t.Name)
                        .IsRequired()
                        .HasMaxLength(200);

                entity.Property(t => t.Description)
                            .HasMaxLength(500);

                entity.Property(t => t.IsCompleted)
                        .HasDefaultValue(false);

                entity.Property(t => t.CreatedAt)
                            .HasDefaultValueSql("GETDATE()");


                entity.HasOne(t => t.user)
                .WithMany(u => u.Task)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            });
        }
    }
}
