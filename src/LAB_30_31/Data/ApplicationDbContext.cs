using LAB_30_31.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB_30_31.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Author> Authors { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public ApplicationDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=1234");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(c =>
            {
                c.ToTable("Categories");

                c.HasKey(c => c.Id);

                c.Property(c => c.Id).ValueGeneratedOnAdd();

            });
            modelBuilder.Entity<Author>(b =>
            {
                b.ToTable("Authors");
                b.HasKey(b => b.Id);
                b.Property(b => b.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Book>(b =>
            {
                b.ToTable("Books");
                b.HasKey(b => b.Id);

                b.Property(b => b.Id).ValueGeneratedOnAdd();

                b.HasOne(b => b.Category).WithMany().HasForeignKey(b => b.CategoryId);
                b.HasOne(b => b.Author).WithMany().HasForeignKey(b => b.AuthorId);
            });

        }
    }
}
