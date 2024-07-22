using System.Security.Claims;
using JWTAuthenticationDotnet.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<UsersController> _logger;
    public UsersController(ApplicationDbContext context, ILogger<UsersController> logger)
    {
        _context = context;
        _logger = logger;
    }
    [Authorize]
    [HttpGet("me")]
    public async Task<IActionResult> GetUser()
    {
           
        var claims = HttpContext.User;
        string userId = claims.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var user = await _context.Users.FindAsync(userId);
        return Ok(user);
    }
    
    [Authorize]
    [HttpGet("all")]
    public async Task<IActionResult> GetUsers()
    {
        _logger.LogInformation("GetUsers called");
        
        if (User.Identity.IsAuthenticated)
        {
            _logger.LogInformation("User is authenticated");
        }
        else
        {
            _logger.LogWarning("User is not authenticated");
            return Unauthorized();
        }



        var users = await _context.Users.ToListAsync();
        return Ok(users);
    }
}