using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.Components.Pages;

namespace TaskManager.Services
{
    public class TaskService(TaskManagerDbContext context) : ITaskService
    {
        private readonly TaskManagerDbContext _context = context;
        public async Task DeleteTask(int id)
        {
            var task = _context.TaskObjects.Single(x =>  x.Id == id);

                _context.TaskObjects.Remove(task);
                await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TaskObject>> GetTasks() =>
            await _context.TaskObjects.ToListAsync();

         public async Task<TaskObject?> GetTask(int id) =>
            await _context.TaskObjects.SingleOrDefaultAsync(x => x.Id == id);

        public async Task<TaskObject> PostTask(TaskObject taskObject)
        {
            _context.TaskObjects.Add(taskObject);
            await _context.SaveChangesAsync();
            return taskObject;
        }

        public async Task PutTask(int id, TaskObject taskObject)
        {
            if (_context.TaskObjects.Any(x => x.Id == id))
            {
                _context.TaskObjects.Update(taskObject);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Unable to process the operation");
            }
        }
    }
}
