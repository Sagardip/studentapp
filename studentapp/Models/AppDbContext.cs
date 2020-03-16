using Microsoft.EntityFrameworkCore;

namespace studentapps.Models
{
    public class AppDbContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<College> Colleges { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
      

        public AppDbContext(DbContextOptions<AppDbContext> options)
               : base(options)
        {

        }


    }
}