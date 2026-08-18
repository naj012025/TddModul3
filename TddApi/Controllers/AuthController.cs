using Microsoft.AspNetCore.Mvc;
using TddApi.Dto;
using TddApi.Services;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<ActionResult<LoginResponse>> Login(
        LoginRequest request)
    {
        LoginResponse? response = await _authService.LoginAsync(request);

        if (response is null)
        {
            return Unauthorized();
        }

        return Ok(response);
    }
}
