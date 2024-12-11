using System.ComponentModel.DataAnnotations;

namespace TaskManager.Components.Pages
{
    public class TaskObject
    {
        public int Id { get; set; }
        [Required]
        [StringLength(45, ErrorMessage = "Title Exceeds Character Limit.(45 Characters)")]
        public string? Title { get; set; }
        [StringLength(45, ErrorMessage = "Description Exceeds Character Limit.(45 Characters)")]
        public string? Description { get; set; }
        public TaskPriority Priority { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public TaskType Type { get; set; }
    }

    public enum TaskPriority
    {
        Low, Medium, High
    }

    public enum TaskType
    {
        Once, Daily, Weekly, Monthly
    }

}
