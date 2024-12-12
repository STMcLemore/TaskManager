using Blazored.Modal;
using Microsoft.EntityFrameworkCore;
using TaskManager.Components;
using MudBlazor.Services;
using TaskManager.Services;
using TaskManager.Data;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddBlazoredModal();
builder.Services.AddScoped<TaskStateService>();
builder.Services.AddScoped<ITaskService, TaskService>();
builder.Services.AddMudServices();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "TaskManager",
        Version = "v1",
        Description = "API documentation for TaskTracker",
    });

});

builder.Services.AddHttpClient("ApiClient", client =>
    {
    client.BaseAddress = new Uri("https://localhost:7046");
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});

builder.Services.AddDbContext<TaskManagerDbContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Task Manager v1");
    c.RoutePrefix = "Swagger"; // Swagger UI accessible at /swagger
});
app.UseHttpsRedirection();

app.UseRouting();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
app.MapControllers();

app.Run();
