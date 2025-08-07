using Microsoft.AspNetCore.Mvc;
using Orion.API.UserProfile.Data;
using Orion.API.UserProfile.Models;
using Orion.Repository.Services;

namespace Orion.API.UserProfile.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserProfileDbContext _dbContext;
    private readonly JwtService _jwtService;

    public AuthController(UserProfileDbContext dbContext, JwtService jwtService)
    {
        _dbContext = dbContext;
        _jwtService = jwtService;
    }
    
    //TODO: This needs to be fixed.
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterUserRequest request)
    {
        // if (_dbContext.UserProfiles.Any(u => u.Username == request.Username))
        //     return BadRequest("Username already exists.");
        //
        // var user = new Core.UserProfile.Domain.UserProfile
        // {
        //     Id = Guid.NewGuid(),
        //     Username = request.Username,
        //     Email = request.Email,
        //     // PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
        //     Role = request.Role
        // };
        //
        // _dbContext.UserProfiles.Add(user);
        await _dbContext.SaveChangesAsync();

        return Ok("User registered successfully.");
    }
    
    //TODO: This needs to be fixed.
    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        // var user = _dbContext.UserProfiles.SingleOrDefault(u => u.Username == request.Username);
        
        //TODO: We need to fix this piece of code and 
        // if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
        //     return Unauthorized("Invalid credentials.");

        // var token = _jwtService.GenerateToken(user);
        // return Ok(new { token });
        throw new NotImplementedException();
    }
}