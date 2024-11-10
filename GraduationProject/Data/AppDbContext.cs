using GraduationProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraduationProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<SuperAdmin> SuperAdmins { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<College> Colleges { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Notifaction> Notifactions { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
