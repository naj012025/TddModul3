using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using TddApi.Data;
using TddApi.Dto;
using TddApi.Services;
using XpTdd.Models;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks();
builder.Services.AddControllers();
builder.Services.AddScoped<PlayerService>();
builder.Services.AddScoped<GoblinService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(
                    builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapHealthChecks("/health");
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseAuthorization();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();

//This public partial class makes it so im able to use the tests.
//it can stay forever has no effect on slowing down the program.
//public partial class Program
//{
//    //Denne partial Class er unødvenig i nyere Dotnet
//}


