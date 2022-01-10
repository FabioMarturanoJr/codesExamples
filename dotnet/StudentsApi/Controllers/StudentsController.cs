using Microsoft.AspNetCore.Mvc;
using StudentsApi.Models;
using StudentsApi.Services;

namespace StudentsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [Produces("application/json")]
    public class StudentsController : ControllerBase
    {
        private IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IAsyncEnumerable<Student>>> GetStudent() {
            try
            {
                var students = await _studentService.GetStudents();
                return Ok(students);
            }
            catch (System.Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
        [HttpGet("StudentByName")]
        public async Task<ActionResult<IAsyncEnumerable<Student>>> GetStudentsByName([FromQuery]string name) {
            try
            {
                var students = await _studentService.GetStudentByName(name);
                if (students.Count() == 0)
                    return NotFound($"Students Not Found with criteria {name}!");

                return Ok(students);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}