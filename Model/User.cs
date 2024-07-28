using Microsoft.AspNetCore.Identity;

namespace SocialApi.Models;
public class User : IdentityUser
{
    public Profile Profile { get; set; }
}