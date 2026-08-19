using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using System.Text;
using TddApi.Data;
using TddApi.Services;
using XpTdd.Models;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks();
builder.Services.AddControllers();
builder.Services.AddAuthorization();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
builder.Services.AddScoped<TokenService>();
builder.Services.AddScoped<PlayerService>();
builder.Services.AddScoped<GoblinService>();
builder.Services.AddScoped<AuthService>();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter your JWT Token quick they are coming!, "
    });
}); //Important i had error beacause of missing These
    // Figured out after i added them its beacuse its nested inside the addswagger gen
    // so needs one for outside and one for inside




builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(
                    builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        string key = builder.Configuration["Jwt:Key"]!;

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,

            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],

            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(key))
        };
    });



var app = builder.Build();


if (app.Environment.IsDevelopment())
{

    app.MapHealthChecks("/health");
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseAuthentication();
app.UseAuthorization();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();

//Temp Hash i need to run for first seed.

//User user = new()
//{
//    UserName = "testuser"
//};

//PasswordHasher<User> hasher = new();

//string hash = hasher.HashPassword(user, "password123");


//Console.WriteLine(hash);


//This public partial class makes it so im able to use the tests.
//it can stay forever has no effect on slowing down the program.

//public partial class Program
//{
//    //This partial class is not required in the newer dotnets i learned.
//}


