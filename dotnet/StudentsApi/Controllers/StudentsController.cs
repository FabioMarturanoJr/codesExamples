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
        [HttpGet("{id:int}", Name="GetStudent")]
        public async Task<ActionResult<Student>> GetStudent(int id) {
            try
            {
                var student = await _studentService.GetStudent(id);

                if (student == null)
                    return NotFound($"Not Found student with id={id}");

                return Ok(student);
            }
            catch (System.Exception e)
            {                
                return BadRequest($"Invalid Request {e.Message}");
            }
        }
        [HttpPost]
        public async Task<ActionResult> Create(Student student) {
            try
            {
                await _studentService.CreateStudent(student);
                return CreatedAtRoute(nameof(GetStudent), new { id = student.Id }, student);
            }
            catch (System.Exception e)
            {                
                return BadRequest($"Invalid Request {e.Message}");
            }
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Edit(int id, [FromBody] Student student) {
            try
            {
                if (student.Id == id) {
                    await _studentService.UpdateStudent(student);
                    return Ok($"Student id={id} updated!");
                }
                return BadRequest("Inconsistents Data");
            }
            catch (System.Exception e)
            {
                return BadRequest($"Invalid Request {e.Message}");
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id) {
            try
            {
                var student = await _studentService.GetStudent(id);
                if (student != null) {
                    await _studentService.DeleteStudent(student);
                    return Ok($"Student id={id} Deleted!");
                }
                return NotFound($"Not Found student with id={id}");
            }
            catch (System.Exception e)
            {
                return BadRequest($"Invalid Request {e.Message}");
            }
        }
    }
}