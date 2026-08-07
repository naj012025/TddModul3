
using Microsoft.AspNetCore;
using TddApi.Controllers;
using TddApi.Dto;
using TddApi.Services;
using XpTdd.Models;

var builder = WebApplication.CreateBuilder(args);

//Addcontrollers Registrer Controller Support
//AddSingleton Lets Depenedency injection reuse playerservice.
//Where it say addsingleton it can change to other states 
//for example:AddTransient or AddScoped:
builder.Services.AddControllers();
builder.Services.AddSingleton<PlayerService>();
builder.Services.AddOpenApi();
//builder.Services.AddScoped<PlayerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//MapControllers activates the routes predefinded in in controllers.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();

//This public partial class makes it so im able to use the tests.
//it can stay forever has no effect on slowing down the program.
public partial class Program
{

}


