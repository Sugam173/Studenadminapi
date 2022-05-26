using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using studentportalapi.DomainModel;
using studentportalapi.Respository;

namespace studentportalapi.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public StudentsController(IStudentRepository studentRepository, IMapper mapper )
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public IActionResult GetAllStudents()
        {
            var students = studentRepository.Students();
            

            return Ok(mapper.Map<List<Student>>(students));

        }
            


    }
        

        
    
}
