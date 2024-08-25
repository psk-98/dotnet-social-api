using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dotnet_social_api.Data;

public class ApplicationDBContext : IdentityDbContext<UserProfile>
{
    public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {

    }

    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }

    public DbSet<Like> Likes { get; set; }
    public DbSet<Follow> Follows { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<MessageThread> MessageThreads { get; set; }
    public DbSet<Message> Messages { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        //Seeding user roles
        List<IdentityRole> roles = new List<IdentityRole>
        {
            new IdentityRole {
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole {
                Name = "User",
                NormalizedName = "USER"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);


        //Seeding user accounts
        builder.Entity<UserProfile>().HasData(
          new UserProfile
          {
              Id = "ed677356-50e3-4640-8077-99db7f391a5b",
              UserName = "Admin",
              NormalizedUserName = "ADMIN",
              Email = "admin@localhost",
              Bio = "System Administrator",
              Website = "http://localhost",
              PasswordHash = new PasswordHasher<UserProfile>().HashPassword(null, "P@ssw0rd123")
          },
          new UserProfile
          {
              Id = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",
              UserName = "DevUser",
              NormalizedUserName = "DEVUSER",
              Email = "devuser@localhost",
              Bio = "Software Developer",
              Website = "http://devsite.local",
              PasswordHash = new PasswordHasher<UserProfile>().HashPassword(null, "P@ssw0rd123")
          },
          new UserProfile
          {
              Id = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",
              UserName = "DesignGuru",
              NormalizedUserName = "DESIGNGURU",
              Email = "designguru@localhost",
              Bio = "Creative Designer",
              Website = "http://design.local",
              PasswordHash = new PasswordHasher<UserProfile>().HashPassword(null, "P@ssw0rd123")
          },
          new UserProfile
          {
              Id = "0f6a348a-760e-4f67-8a72-fb1397b43f23",
              UserName = "Marketer",
              NormalizedUserName = "MARKETER",
              Email = "marketer@localhost",
              Bio = "Marketing Specialist",
              Website = "http://market.local",
              PasswordHash = new PasswordHasher<UserProfile>().HashPassword(null, "P@ssw0rd123")
          },
          new UserProfile
          {
              Id = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",
              UserName = "SupportTech",
              NormalizedUserName = "SUPPORTTECH",
              Email = "supporttech@localhost",
              Bio = "Customer Support Tech",
              Website = "http://support.local",
              PasswordHash = new PasswordHasher<UserProfile>().HashPassword(null, "P@ssw0rd123")
          }
      );
    }
}
