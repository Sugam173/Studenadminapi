using Microsoft.EntityFrameworkCore;
namespace studentportalapi.DataModel
{


    public class Studentadmincontext : DbContext
    {

        public Studentadmincontext(DbContextOptions<Studentadmincontext> options) : base(options)

        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Gender> Gender { get; set; }

    }


}