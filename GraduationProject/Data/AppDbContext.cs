using Microsoft.EntityFrameworkCore;

namespace GraduationProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    }
}
