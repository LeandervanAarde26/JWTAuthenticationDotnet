using System.Security.Claims;
using JWTAuthenticationDotnet.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JWTAuthenticationDotnet.Controllers;
    [ApiController]
    [Route("")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ApplicationDbContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
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
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }
    }
