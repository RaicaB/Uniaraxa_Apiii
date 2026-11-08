using Microsoft.AspNetCore.Mvc;
using Uniaraxa.Domain.Entities;
using Uniaraxa.Service.services;
using Uniaraxa.Service.Services;

namespace Uniaraxa.APII.Controllers
{
    public class StudentController : ControllerBase
    {

        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;

        }

        [HttpGet]
        [Route("api/student")]
        public IActionResult GetAllStudents()
        {
            var students = _studentService.GetAllStudents();
            if (students == null || !students.Any())
            {
                return NotFound("No students found.");
            }
            return Ok(students);
        }

        [HttpGet]
        [Route("api/student/<id>")]
        public IActionResult GetStudentsById(int id)
        {
            var students = _studentService.GetStudentById(id);
            if (students is null)
            {
                return NotFound("No students found.");
            }
            return Ok(students);
        }


        [HttpPost]
        [Route("api/student/<id>")]
        public IActionResult AddStudent([FromBody] Student student)
        {
            _studentService.AddStudent(student);
            return CreatedAtAction(nameof(GetStudentsById), new { id = student.Id });
        }

        [HttpDelete]
        [Route("api/student/<id>")]
        public IActionResult DeleteStudent(int id)

        {
            var students = _studentService.GetStudentById(id);
            _studentService.DeleteStudent(id);
            return NoContent();


        }
    }
}
