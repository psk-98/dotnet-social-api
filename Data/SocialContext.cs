using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialApi.Models;

namespace SocialApi.Data;

public class SocialContext : IdentityDbContext<User>
{
    public SocialContext(DbContextOptions<SocialContext> options)
        : base(options) { }

    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Post> Posts { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Configure the relationship between User and Profile
        builder.Entity<User>()
            .HasOne(u => u.Profile)
            .WithOne(p => p.User)
            .HasForeignKey<Profile>(p => p.UserId);

        // Configure the relationship between Post and Profile
        builder.Entity<Post>()
            .HasOne(post => post.Profile)    // Post has one Profile
            .WithMany(profile => profile.Posts)  // Profile has many Posts
            .HasForeignKey(post => post.ProfileId);  // Foreign key in Post
    }
}

