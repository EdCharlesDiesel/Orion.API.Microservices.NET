using Microsoft.AspNetCore.Mvc;
using Orion.API.UserProfile.API.Data;
using Orion.API.UserProfile.API.Models;
using Orion.API.UserProfile.API.Services;

namespace Orion.API.UserProfile.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserDbContext _context;
    private readonly JwtService _jwtService;

    public AuthController(UserDbContext context, JwtService jwtService)
    {
        _context = context;
        _jwtService = jwtService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterUserRequest request)
    {
        if (_context.Users.Any(u => u.Username == request.Username))
            return BadRequest("Username already exists.");

        var user = new OrionUserProfile.Domain.UserProfile
        {
            Id = Guid.NewGuid(),
            Username = request.Username,
            Email = request.Email,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
            Role = request.Role
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return Ok("User registered successfully.");
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var user = _context.Users.SingleOrDefault(u => u.Username == request.Username);
        if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
            return Unauthorized("Invalid credentials.");

        var token = _jwtService.GenerateToken(user);
        return Ok(new { token });
    }
}