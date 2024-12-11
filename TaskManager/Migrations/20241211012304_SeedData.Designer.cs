﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManager.Data;

#nullable disable

namespace TaskManager.Migrations
{
    [DbContext(typeof(TaskManagerDbContext))]
    [Migration("20241211012304_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("TaskManager.Components.Pages.TaskObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("TaskObjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Give cat 1/4 cup of food in the morning",
                            DueDate = new DateTime(2024, 11, 22, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Priority = 2,
                            Title = "Feed Cat",
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Buy milk, eggs, bread, and vegetables",
                            DueDate = new DateTime(2024, 11, 23, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Priority = 2,
                            Title = "Grocery Shopping",
                            Type = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "Review expenses and allocate funds for the next month",
                            DueDate = new DateTime(2024, 11, 30, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Priority = 2,
                            Title = "Plan Monthly Budget",
                            Type = 3
                        },
                        new
                        {
                            Id = 6,
                            Description = "Vacuum the carpet and dust all surfaces in the living room",
                            DueDate = new DateTime(2024, 11, 26, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Priority = 1,
                            Title = "Clean Living Room",
                            Type = 2
                        },
                        new
                        {
                            Id = 7,
                            Description = "Pay electricity, water, and internet bills online",
                            DueDate = new DateTime(2024, 11, 28, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Priority = 2,
                            Title = "Pay Utility Bills",
                            Type = 3
                        },
                        new
                        {
                            Id = 8,
                            Description = "Complete a 30-minute workout routine",
                            DueDate = new DateTime(2024, 11, 22, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Priority = 2,
                            Title = "Morning Exercise",
                            Type = 1
                        },
                        new
                        {
                            Id = 9,
                            Description = "Read one chapter of Wind and Truth",
                            DueDate = new DateTime(2024, 11, 22, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Priority = 0,
                            Title = "Read a Book",
                            Type = 1
                        },
                        new
                        {
                            Id = 10,
                            Description = "Finalize slides for the upcoming team meeting",
                            DueDate = new DateTime(2024, 11, 27, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Priority = 2,
                            Title = "Prepare Presentation",
                            Type = 2
                        },
                        new
                        {
                            Id = 11,
                            Description = "Sort paperwork, tidy desk, and declutter workspace",
                            DueDate = new DateTime(2024, 11, 25, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Priority = 1,
                            Title = "Organize Workspace",
                            Type = 2
                        },
                        new
                        {
                            Id = 12,
                            Description = "Prepare meals for the next three days",
                            DueDate = new DateTime(2024, 11, 26, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false,
                            Priority = 2,
                            Title = "Meal Prep",
                            Type = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}