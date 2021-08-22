
namespace EducCenter.Data
{
    using EducCenter.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;

    public class EducCenterDbContext : IdentityDbContext
    {
        public EducCenterDbContext(DbContextOptions<EducCenterDbContext> options)
            : base(options)
        {

        }
        public DbSet<Course> Courses { get; init; }

        public DbSet<Student> Students { get; init; }

        public DbSet<StudentCourse> StudentCourses { get; init; }

        public DbSet<Subject> Subjects { get; init; }

        public DbSet<Teacher> Teachers { get; init; }

        public DbSet<TeacherCourse> TeacherCourses { get; init; }

        public DbSet<SubjectCourse>  SubjectCourses{ get; init; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Course>()
                .Property(x => x.Price)
                .HasColumnType("decimal(6,3)");

            builder
                .Entity<TeacherCourse>()
                .HasOne(t => t.Teacher)
                .WithMany(c => c.Courses)
                .HasForeignKey(c => c.TeacherId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<TeacherCourse>()
                .HasOne(c => c.Course)
                .WithMany(t => t.Teachers)
                .HasForeignKey(c => c.CourseId)
                 .OnDelete(DeleteBehavior.Restrict);
            builder
                .Entity<StudentCourse>()
                .HasOne(c => c.Course)
                .WithMany(t => t.Students)
                .HasForeignKey(c => c.CourseId)
                 .OnDelete(DeleteBehavior.Restrict);
            builder
                .Entity<StudentCourse>()
                .HasOne(c => c.Student)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.StudentId)
                 .OnDelete(DeleteBehavior.Restrict);


            builder
                .Entity<SubjectCourse>()
                .HasOne(r => r.Subject)
                .WithMany(sl => sl.Courses)
                .HasForeignKey(sl => sl.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<SubjectCourse>()
                .HasOne(c => c.Course)
                .WithMany(t => t.Subjects)
                .HasForeignKey(c => c.CourseId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Teacher>()
                .HasOne(t => t.ChildId)
                .WithMany(c => c.Teachers)
                .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-58VR2AG\SQLEXPRESS;Database=EducCenter;Integrated Security=True;");
            }
        }
        
    }
}
