using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Orion.API.UserProfile.API.Data;
using Orion.API.UserProfile.API.Models;

namespace Orion.API.UserProfile.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly UserProfileContext _context;

    public UserController(UserProfileContext context)
    {
        _context = context;
    }

    [Authorize]
    [HttpGet("profile")]
    public IActionResult GetProfile()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (userId == null) return Unauthorized();

        var user = _context.UserProfiles.Find(Guid.Parse(userId));
        if (user == null) return NotFound();

        return Ok(new
        {
            user.Id,
            user.Username,
            user.Email,
            user.Role,
            user.FirstName,
            user.LastName,
            user.DateOfBirth
        });
    }

    [Authorize(Roles = "Admin")]
    [HttpGet("all")]
    public IActionResult GetAllUsers()
    {
        return Ok(_context.UserProfiles.ToList());
    }
}