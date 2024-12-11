using System.Collections.Generic;
using System.Reflection.Emit;
using TaskManager.Components.Pages;
using Microsoft.EntityFrameworkCore;

namespace TaskManager.Data
{
        public class TaskManagerDbContext : DbContext
        {
            public DbSet<TaskObject> TaskObjects { get; set; }

            public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> options) : base(options) { }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<TaskObject>().HasKey(t => t.Id);



                modelBuilder.Entity<TaskObject>().HasData(
                    new TaskObject
                    {
                        Id = 1,
                        Title = "Feed Cat",
                        Description = "Give cat 1/4 cup of food in the morning",
                        Priority = TaskPriority.High,
                        IsCompleted = false,
                        Type =
                        TaskType.Daily,
                        DueDate = new DateTime(2024, 11, 22, 12, 0, 0)
                    },
                    new TaskObject
                    {
                        Id = 2,
                        Title = "Grocery Shopping",
                        Description = "Buy milk, eggs, bread, and vegetables",
                        Priority = TaskPriority.High,
                        IsCompleted = false,
                        Type = TaskType.Weekly,
                        DueDate = new DateTime(2024, 11, 23, 10, 0, 0)
                    },
                     new TaskObject
                     {
                         Id = 3,
                         Title = "Plan Monthly Budget",
                         Description = "Review expenses and allocate funds for the next month",
                         Priority = TaskPriority.High,
                         IsCompleted = false,
                         Type = TaskType.Monthly,
                         DueDate = new DateTime(2024, 11, 30, 15, 0, 0)
                     },
                      new TaskObject
                      {
                          Id = 6,
                          Title = "Clean Living Room",
                          Description = "Vacuum the carpet and dust all surfaces in the living room",
                          Priority = TaskPriority.Medium,
                          IsCompleted = false,
                          Type = TaskType.Weekly,
                          DueDate = new DateTime(2024, 11, 26, 14, 0, 0)
                      },
                       new TaskObject
                       {
                           Id = 7,
                           Title = "Pay Utility Bills",
                           Description = "Pay electricity, water, and internet bills online",
                           Priority = TaskPriority.High,
                           IsCompleted = false,
                           Type = TaskType.Monthly,
                           DueDate = new DateTime(2024, 11, 28, 12, 0, 0)
                       },
                       new TaskObject
                       {
                           Id = 8,
                           Title = "Morning Exercise",
                           Description = "Complete a 30-minute workout routine",
                           Priority = TaskPriority.High,
                           IsCompleted = false,
                           Type = TaskType.Daily,
                           DueDate = new DateTime(2024, 11, 22, 7, 0, 0)
                       },
                       new TaskObject
                       {
                           Id = 9,
                           Title = "Read a Book",
                           Description = "Read one chapter of Wind and Truth",
                           Priority = TaskPriority.Low,
                           IsCompleted = false,
                           Type = TaskType.Daily,
                           DueDate = new DateTime(2024, 11, 22, 20, 0, 0)
                       },
                       new TaskObject
                       {
                           Id = 10,
                           Title = "Prepare Presentation",
                           Description = "Finalize slides for the upcoming team meeting",
                           Priority = TaskPriority.High,
                           IsCompleted = false,
                           Type = TaskType.Weekly,
                           DueDate = new DateTime(2024, 11, 27, 16, 0, 0)
                       },
                       new TaskObject
                       {
                           Id = 11,
                           Title = "Organize Workspace",
                           Description = "Sort paperwork, tidy desk, and declutter workspace",
                           Priority = TaskPriority.Medium,
                           IsCompleted = false,
                           Type = TaskType.Weekly,
                           DueDate = new DateTime(2024, 11, 25, 11, 0, 0)
                       },
                       new TaskObject
                       {
                           Id = 12,
                           Title = "Meal Prep",
                           Description = "Prepare meals for the next three days",
                           Priority = TaskPriority.High,
                           IsCompleted = false,
                           Type = TaskType.Weekly,
                           DueDate = new DateTime(2024, 11, 26, 17, 0, 0)
                       });

                base.OnModelCreating(modelBuilder);
            }
        }
    }
