using Microsoft.EntityFrameworkCore;
using third_assignment.Models;

namespace third_assignment.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        
    }
}
