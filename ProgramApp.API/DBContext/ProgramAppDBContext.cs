using Microsoft.EntityFrameworkCore;
using ProgramApp.Database.Models;

namespace ProgramApp.API.DBContext
{
    public class ProgramAppDBContext :DbContext
    {
        public ProgramAppDBContext(DbContextOptions<ProgramAppDBContext> options):base(options)
        {
            
        }

        public DbSet<ProgramDetail> programs { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Stage> stages { get; set; }
    }
}
