
using System.ComponentModel.DataAnnotations;

namespace SocialApi.Models;

public class Profile
{
    public int Id { get; set; }
    [Required]
    public string Username { get; set; }

    public string UserId { get; set; }

    public User User { get; set; }

    // Navigation property for related posts
    public ICollection<Post> Posts { get; set; } = new List<Post>();

}

