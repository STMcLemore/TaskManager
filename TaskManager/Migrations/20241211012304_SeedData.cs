using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManager.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TaskObjects",
                columns: new[] { "Id", "Description", "DueDate", "IsCompleted", "Priority", "Title", "Type" },
                values: new object[,]
                {
                    { 2, "Buy milk, eggs, bread, and vegetables", new DateTime(2024, 11, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), false, 2, "Grocery Shopping", 2 },
                    { 3, "Review expenses and allocate funds for the next month", new DateTime(2024, 11, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), false, 2, "Plan Monthly Budget", 3 },
                    { 6, "Vacuum the carpet and dust all surfaces in the living room", new DateTime(2024, 11, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), false, 1, "Clean Living Room", 2 },
                    { 7, "Pay electricity, water, and internet bills online", new DateTime(2024, 11, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), false, 2, "Pay Utility Bills", 3 },
                    { 8, "Complete a 30-minute workout routine", new DateTime(2024, 11, 22, 7, 0, 0, 0, DateTimeKind.Unspecified), false, 2, "Morning Exercise", 1 },
                    { 9, "Read one chapter of Wind and Truth", new DateTime(2024, 11, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), false, 0, "Read a Book", 1 },
                    { 10, "Finalize slides for the upcoming team meeting", new DateTime(2024, 11, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), false, 2, "Prepare Presentation", 2 },
                    { 11, "Sort paperwork, tidy desk, and declutter workspace", new DateTime(2024, 11, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), false, 1, "Organize Workspace", 2 },
                    { 12, "Prepare meals for the next three days", new DateTime(2024, 11, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 2, "Meal Prep", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskObjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaskObjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaskObjects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TaskObjects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TaskObjects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TaskObjects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TaskObjects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TaskObjects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TaskObjects",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
