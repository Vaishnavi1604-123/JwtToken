using Microsoft.EntityFrameworkCore;

namespace JwtToken.Models
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext()
        {

        }
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {

        }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
       
    }
}
