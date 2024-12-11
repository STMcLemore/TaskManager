using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.Components.Pages;
using TaskManager.Services;
using TaskManager.Data;

namespace TaskManager.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController(ITaskService taskService) : ControllerBase
    {
        private readonly ITaskService _taskService = taskService;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskObject?>>> GetTasks()
        {
            try
            {
                var result = await _taskService.GetTasks();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<TaskObject>> GetTask(int id)
        {
            try
            {
                var taskObject = await _taskService.GetTask(id);

                if (taskObject == null)
                {
                    return NotFound($"Task with ID {id} not found.");
                }

                return Ok(taskObject);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpPost]
        public async Task<ActionResult<TaskObject>> PostTask(TaskObject taskObject)
        {
            try
            {
                if (taskObject == null)
                {
                    return BadRequest("Task data is missing.");
                }

                await _taskService.PostTask(taskObject);
                return Ok(taskObject);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutTask(int id, TaskObject taskObject)
        {
            try
            {
                await _taskService.PutTask(id, taskObject);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            try
            {
                await _taskService.DeleteTask(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
