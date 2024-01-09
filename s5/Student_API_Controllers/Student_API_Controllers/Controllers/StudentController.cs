using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;

namespace Student_API_Controllers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student { Id = 1, FirstName = "Paul", LastName = "Ochon", Birthdate = new DateTime(1950, 12, 1) },
            new Student { Id = 2, FirstName = "Daisy", LastName = "Drathey", Birthdate = new DateTime(1970, 12, 1) },
            new Student { Id = 3, FirstName = "Elie", LastName = "Coptaire", Birthdate = new DateTime(1980, 12, 1) }
        };

        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetStudents")]
        public IEnumerable<Student> Get()
        {
            return (IEnumerable<Student>) _students;
        }

        [HttpGet("GetStudentById")]
        public Student GetStudentById(int id)
        {
             Student? student = (from Student s in _students 
                               where s.Id == id 
                               select s).SingleOrDefault();
            return student;
        }

        [HttpPost("PostStudent")]
        public Student PostStudent(string firstName, string lastName, DateTime birthDate)
        {
            Student student = new Student
            {
                Id = _students.Count + 1,
                FirstName = firstName,
                LastName = lastName,
                Birthdate = birthDate
            };
            _students.Add(student);
            return student;
        }
    }
}
