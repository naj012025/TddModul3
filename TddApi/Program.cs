
using Microsoft.AspNetCore;
using TddApi.Controllers;
using TddApi.Dto;
using TddApi.Services;
using XpTdd.Models;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddTransient<PlayerService>();
builder.Services.AddScoped<PlayerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program
{

}
