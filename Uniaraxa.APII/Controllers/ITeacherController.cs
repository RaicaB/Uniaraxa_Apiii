using Microsoft.AspNetCore.Mvc;
using Uniaraxa.Domain.Entities;

namespace Uniaraxa.APII.Controllers
{
    public interface ITeacherController
    {
        IActionResult AddTeacher([FromBody] Teacher teacher);
        IActionResult DeleteTeacher(int id);
        IActionResult GetAllTeacher();
        IActionResult GetTeacherById(int id);
        IActionResult UpdateTeacher(int id, [FromBody] Teacher teacher);
    }
}