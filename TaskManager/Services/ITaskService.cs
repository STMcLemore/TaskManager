using Microsoft.AspNetCore.Mvc;
using TaskManager.Components.Pages;

namespace TaskManager.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskObject>> GetTasks();
        Task<TaskObject?> GetTask(int id);
        Task<TaskObject> PostTask(TaskObject taskObject);
        Task PutTask(int id, TaskObject taskObject);
        Task DeleteTask(int id);
    }
}
