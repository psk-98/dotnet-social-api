using System.ComponentModel.DataAnnotations;

namespace SocialApi.Models;

public class Post
{
    [Key]
    public int Id { get; set; }
    public int ProfileId { get; set; }
    public Profile Profile { get; set; }
    public string? Body { get; set; }
    public DateTimeOffset Created { get; set; }
}