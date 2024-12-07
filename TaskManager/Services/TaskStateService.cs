using TaskManager.Components.Pages;

namespace TaskManager.Services
{
    public class TaskStateService
    {
        public List<TaskObject> Tasks { get; set; } = new List<TaskObject>();
        public List<TaskObject> CompletedTasks { get; set; } = new List<TaskObject>();
    }
}
