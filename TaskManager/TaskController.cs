using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.Components.Pages;
using static TaskManager.TaskManagerDbContext;

namespace TaskManager
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly TaskManagerDbContext _context;

        public TaskController(TaskManagerDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskObject>>> GetTasks()
        {
            return await _context.TaskObjects.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskObject>> GetTask(int id)
        {
            var taskObject = await _context.TaskObjects.FindAsync(id);

            if (taskObject == null)
            {
                return NotFound();
            }
            return taskObject;
        }

        [HttpPost]
        public async Task<ActionResult<TaskObject>> PostTask([FromBody] TaskObject taskObject)
        {
            if (taskObject == null)
            {
                return BadRequest("Data is missing");
            }

            Console.WriteLine($"Received Task - Title: {taskObject.Title}, Description: {taskObject.Description}, Priority: {taskObject.Priority}, DueDate: {taskObject.DueDate}");

            try
            {
                _context.TaskObjects.Add(taskObject);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetTask", new { id = taskObject.Id }, taskObject);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTask(int id, TaskObject taskObject)
        {
            if (id != taskObject.Id)
            {
                return BadRequest();
            }

            _context.Entry(taskObject).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var taskObject = await _context.TaskObjects.FindAsync(id);
            if (taskObject == null)
            {
                return NotFound();
            }

            _context.TaskObjects.Remove(taskObject);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
