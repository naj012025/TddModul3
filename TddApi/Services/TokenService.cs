using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using XpTdd.Models;

namespace TddApi.Services
{
    public class TokenService
    {

        //parameter IConfiguration is for the jason aspnet core accses. 
        private readonly IConfiguration _configuration;
        //makes it so the private iconfigureatin can be used. delete these later after.
        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string CreateToken(User user)
        {
            string key = _configuration["Jwt:Key"]!;
            string issuer = _configuration["Jwt:Issuer"]!;
            string audience = _configuration["Jwt:Audience"]!;

            SymmetricSecurityKey securityKey =
                new(Encoding.UTF8.GetBytes(key));

            SigningCredentials credentials =
                new(securityKey, SecurityAlgorithms.HmacSha256);

            Claim[] claims = new[]
            {
              new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
              new Claim(ClaimTypes.Name, user.UserName)
            };

            JwtSecurityToken token = new(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }




    }
}
