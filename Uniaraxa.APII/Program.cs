using Uniaraxa.Domain.Interfaces;
using Uniaraxa.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

NewMethod(builder);
builder.Services.AddScoped<ITeacherService, TeacherService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static void NewMethod(WebApplicationBuilder builder)
{
    builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
}