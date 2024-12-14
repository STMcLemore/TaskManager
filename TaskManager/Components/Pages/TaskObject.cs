using Microsoft.AspNetCore.Http.HttpResults;
using Newtonsoft.Json.Linq;
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

    // This class adheres to the Single-Responsibility Principle of the S.O.L.I.D design principles for the following reaons:

    //    1.Single Purpose: Its sole purpose is to define a task object and its related attributes.

    //    2.Single Reason to Change: Changes to this class would only occur if the task-related data model needs modification 
    //    (e.g., adding a new property like Category or updating validation rules).

    //    3.Separation of Concerns: It does not include behaviors like saving to a database,
    //    rendering UI, or applying task-specific business rules.


    // This class adheres to the Open/Closed Principle Principle of the S.O.L.I.D design principles because it defines properties 
    // and validation rules in a way that supports the addition of new task-related properties or enums without modifying its 
    // core structure.For example:

    //     You can add new properties(e.g., Category) without breaking the existing implementation.

    //     Enums like TaskPriority or TaskType can be extended by adding new values without modifying the class logic.
}
