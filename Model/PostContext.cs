using Microsoft.EntityFrameworkCore;

namespace SocialApi.Models;

public class PostContext : DbContext {
    public PostContext(DbContextOptions<PostContext> options)
        : base(options)
    {
    }

    public DbSet<Post> Post { get; set; } = null!;
}