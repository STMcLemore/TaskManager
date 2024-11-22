using System.Collections.Generic;
using System.Reflection.Emit;
using TaskManager.Components.Pages;
using Microsoft.EntityFrameworkCore;

namespace TaskManager
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
                    });

                base.OnModelCreating(modelBuilder);
            }
        }
    }
