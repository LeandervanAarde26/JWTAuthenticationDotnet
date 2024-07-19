using Microsoft.AspNetCore.Identity;

namespace JWTAuthenticationDotnet.Database;

public class User : IdentityUser
{
    public string? Initials { get; set; }
}