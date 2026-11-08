using Microsoft.AspNetCore.Mvc;
using Uniaraxa.Domain.Entities;
using Uniaraxa.Service.services;
using Uniaraxa.Service.Services;

namespace Uniaraxa.APII.Controllers
{
        namespace Uniaraxa.APII.Controllers

    { 
    
        public class TeacherController : ControllerBase
        {

            private readonly ITeacherService _teacherService;

            public TeacherController(ITeacherService teacherService)
            {
                _teacherService = teacherService;
            }


        [HttpGet]
        [Route("api/teacher")]
        public IActionResult GetAllTeacher()
        {
            var teacher = _teacherService.GetAllTeacher();
            if (teacher == null || !teacher.Any())
            {
                return NotFound("No teachers found.");
            }
            return Ok(teacher);
        }


        [HttpGet]
        [Route("api/teacher/<id>")]
            public IActionResult GetAllTeacher(int id)
            {
                var teachers = _teacherService.GetAllTeacher();
                return Ok(teachers);
            }


            [HttpGet("{id:int}")]
            public IActionResult GetTeacherById(int id)
            {
                var teacher = _teacherService.GetTeacherById(id);
                if (teacher is null)
                    return NotFound("Teacher not found.");

                return Ok(teacher);
            }


            [HttpPost]
            public IActionResult AddTeacher([FromBody] Teacher teacher)
            {
                _teacherService.AddTeacher(teacher);
                return CreatedAtAction(nameof(GetTeacherById), new { id = teacher.Id }, teacher);
            }


            [HttpPut("{id:int}")]
            public IActionResult UpdateTeacher(int id, [FromBody] Teacher teacher)
            {
                var existing = _teacherService.GetTeacherById(id);
                if (existing is null)
                    return NotFound("Teacher not found.");

                teacher.Id = id;
                _teacherService.UpdateTeacher(teacher);
                return NoContent();
            }


            [HttpDelete("{id:int}")]
            public IActionResult DeleteTeacher(int id)
            {
                var existing = _teacherService.GetTeacherById(id);
                if (existing is null)
                    return NotFound("Teacher not found.");

                _teacherService.DeleteTeacher(id);
                return NoContent();
            }
        }
    }
}