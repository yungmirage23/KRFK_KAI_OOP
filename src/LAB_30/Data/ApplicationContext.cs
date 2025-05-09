using LAB_30.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB_30.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Group> Groups => Set<Group>();

        public DbSet<Student> Students => Set<Student>();

        public DbSet<Grade> Grades => Set<Grade>();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=1234");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("groups");

                entity.HasKey(g => g.Id);

                entity.Property(g => g.Id).HasColumnName("id");
                entity.Property(g => g.GroupName).HasColumnName("group_name");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("students");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(s => s.FullName).HasColumnName("full_name");
                entity.Property(s => s.GroupId).HasColumnName("group_id");

                entity.HasOne<Group>(s => s.Group).WithMany().HasForeignKey(x => x.GroupId).HasConstraintName("students_pkey");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.ToTable("grades");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(g => g.SubjectName).HasColumnName("subject_name");
                entity.Property(g => g.Score).HasColumnName("score");
                entity.Property(g => g.StudentId).HasColumnName("student_id");
               
                entity.HasOne<Student>(g => g.Student).WithMany().HasForeignKey(x => x.StudentId).HasConstraintName("grades_pkey");
            });
        }

    }
}
