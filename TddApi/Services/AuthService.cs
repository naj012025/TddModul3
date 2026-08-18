using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security;
using System.Security.Cryptography;
using TddApi.Data;
using TddApi.Dto;
using XpTdd.Models;

namespace TddApi.Services
{
    public class AuthService
    {
        private readonly AppDbContext _dbContext;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly TokenService _tokenService;

        public AuthService(
            AppDbContext dbContext,
            IPasswordHasher<User> passwordHasher,
            TokenService tokenService)
        {
            _dbContext = dbContext;
            _passwordHasher = passwordHasher;
            _tokenService = tokenService;
        }

        public async Task<LoginResponse?> LoginAsync(LoginRequest request)
        {
            User? user = await _dbContext.Users
                .FirstOrDefaultAsync(u => u.UserName == request.UserName);

            if (user is null)
            {
                return null;
            }

            PasswordVerificationResult result =
                _passwordHasher.VerifyHashedPassword(
                    user,
                    user.PasswordHash,
                    request.Password);

            if (result == PasswordVerificationResult.Failed)
            {
                return null;
            }

            string token = _tokenService.CreateToken(user);

            return new LoginResponse
            {
                Token = token
            };
        }





    }
}
