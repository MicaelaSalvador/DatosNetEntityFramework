using Microsoft.EntityFrameworkCore;
using StudentEntityFramework.Data.Config;

namespace StudentEntityFramework.Data
{
    public class CollageDBContext:DbContext
    {
        public CollageDBContext(DbContextOptions<CollageDBContext> options): base(options) 
        {
            
        }
        DbSet<Student> Students {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Table 1
            modelBuilder.ApplyConfiguration(new StudentConfig());

            // Table 2
            // Table 3
            
        }

    }
}
