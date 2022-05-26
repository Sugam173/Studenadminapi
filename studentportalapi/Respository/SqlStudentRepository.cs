using Microsoft.EntityFrameworkCore;
using studentportalapi.DataModel;

namespace studentportalapi.Respository
{
    public class SqlStudentRepository : IStudentRepository
    {
        private Studentadmincontext context;

        public SqlStudentRepository(Studentadmincontext context)
        {
            this.context = context;
        }
        public List<Student> Students()

        {
            return context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToList();
        }

    }    
}
