using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.Components.Pages;
using TaskManager.Services;
using static TaskManager.TaskManagerDbContext;

namespace TaskManager
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController(ITaskService taskService) : ControllerBase
    {
        private readonly ITaskService _taskService = taskService;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskObject?>>> GetTasks()
        {
            var result = await _taskService.GetTasks();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskObject>> GetTask(int id)
        {
            var taskObject = await _taskService.GetTask(id);

            if (taskObject == null)
            {
                return NotFound();
            }
            return Ok(taskObject);
        }

        [HttpPost]
        public async Task<ActionResult<TaskObject>> PostTask(TaskObject taskObject)
        {
            if (taskObject is null)
            {
                return BadRequest("Data is missing");
            }
            await _taskService.PostTask(taskObject);
            return Ok(taskObject);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTask(int id, TaskObject taskObject)
        {
            await _taskService.PutTask(id, taskObject);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            await _taskService.DeleteTask(id);
            return Ok();
        }
    }
}
