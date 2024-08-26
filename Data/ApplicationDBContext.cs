using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Models;
using dotnet_social_api.Models.Enums;
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
        var currentDate = DateTime.UtcNow;
        // NotificationType notificationType;

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


        //seeding user posts
        builder.Entity<Post>().HasData(

            // Posts for Admin
            new Post
            {
                Id = 1,
                UserProfileId = "ed677356-50e3-4640-8077-99db7f391a5b",
                Body = "Welcome to the system! Excited to have you here.",
                CreatedOn = currentDate.AddDays(-1)
            },
            new Post
            {
                Id = 2,
                UserProfileId = "ed677356-50e3-4640-8077-99db7f391a5b",
                Body = "System maintenance scheduled for tonight.",
                CreatedOn = currentDate.AddHours(-6)
            },
            new Post
            {
                Id = 3,
                UserProfileId = "ed677356-50e3-4640-8077-99db7f391a5b",
                Body = "New feature release notes available in the documentation.",
                CreatedOn = currentDate.AddDays(-2)
            },
            new Post
            {
                Id = 4,
                UserProfileId = "ed677356-50e3-4640-8077-99db7f391a5b",
                Body = "Reminder: Update your profile settings.",
                CreatedOn = currentDate.AddDays(-3)
            },
            new Post
            {
                Id = 5,
                UserProfileId = "ed677356-50e3-4640-8077-99db7f391a5b",
                Body = "Check out the latest system reports.",
                CreatedOn = currentDate.AddDays(-4)
            },

            // Posts for DevUser
            new Post
            {
                Id = 6,
                UserProfileId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",
                Body = "Just pushed a new update to the repository.",
                CreatedOn = currentDate.AddDays(-1)
            },
            new Post
            {
                Id = 7,
                UserProfileId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",
                Body = "Working on improving the API performance.",
                CreatedOn = currentDate.AddDays(-2)
            },
            new Post
            {
                Id = 8,
                UserProfileId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",
                Body = "Dev meetup scheduled for next week.",
                CreatedOn = currentDate.AddDays(-3)
            },
            new Post
            {
                Id = 9,
                UserProfileId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",
                Body = "New blog post on best coding practices.",
                CreatedOn = currentDate.AddDays(-4)
            },
            new Post
            {
                Id = 10,
                UserProfileId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",
                Body = "Exploring new tools for developers.",
                CreatedOn = currentDate.AddDays(-5)
            },

            // Posts for DesignGuru
            new Post
            {
                Id = 11,
                UserProfileId = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",
                Body = "Check out the latest design trends.",
                CreatedOn = currentDate.AddDays(-1)
            },
            new Post
            {
                Id = 12,
                UserProfileId = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",
                Body = "Redesigned the homepage for a client.",
                CreatedOn = currentDate.AddDays(-2)
            },
            new Post
            {
                Id = 13,
                UserProfileId = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",
                Body = "Design tips for creating effective UI.",
                CreatedOn = currentDate.AddDays(-3)
            },
            new Post
            {
                Id = 14,
                UserProfileId = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",
                Body = "How to use color theory in design.",
                CreatedOn = currentDate.AddDays(-4)
            },
            new Post
            {
                Id = 15,
                UserProfileId = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",
                Body = "Design project management tips.",
                CreatedOn = currentDate.AddDays(-5)
            },

            // Posts for Marketer
            new Post
            {
                Id = 16,
                UserProfileId = "0f6a348a-760e-4f67-8a72-fb1397b43f23",
                Body = "New marketing strategy launched.",
                CreatedOn = currentDate.AddDays(-1)
            },
            new Post
            {
                Id = 17,
                UserProfileId = "0f6a348a-760e-4f67-8a72-fb1397b43f23",
                Body = "Top 5 tips for effective social media marketing.",
                CreatedOn = currentDate.AddDays(-2)
            },
            new Post
            {
                Id = 18,
                UserProfileId = "0f6a348a-760e-4f67-8a72-fb1397b43f23",
                Body = "Exploring new digital marketing tools.",
                CreatedOn = currentDate.AddDays(-3)
            },
            new Post
            {
                Id = 19,
                UserProfileId = "0f6a348a-760e-4f67-8a72-fb1397b43f23",
                Body = "Analyzing the latest marketing trends.",
                CreatedOn = currentDate.AddDays(-4)
            },
            new Post
            {
                Id = 20,
                UserProfileId = "0f6a348a-760e-4f67-8a72-fb1397b43f23",
                Body = "Effective strategies for increasing engagement.",
                CreatedOn = currentDate.AddDays(-5)
            },

            // Posts for SupportTech
            new Post
            {
                Id = 21,
                UserProfileId = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",
                Body = "Support hours extended this week.",
                CreatedOn = currentDate.AddDays(-1)
            },
            new Post
            {
                Id = 22,
                UserProfileId = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",
                Body = "New troubleshooting guide available.",
                CreatedOn = currentDate.AddDays(-2)
            },
            new Post
            {
                Id = 23,
                UserProfileId = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",
                Body = "How to resolve common support issues.",
                CreatedOn = currentDate.AddDays(-3)
            },
            new Post
            {
                Id = 24,
                UserProfileId = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",
                Body = "Tips for better customer support.",
                CreatedOn = currentDate.AddDays(-4)
            },
            new Post
            {
                Id = 25,
                UserProfileId = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",
                Body = "New features in the support portal.",
                CreatedOn = currentDate.AddDays(-5)
            }

        );

        // seeding comments
        builder.Entity<Comment>().HasData(
        new Comment
        {
            Id = 1,
            Body = "Great post! Really enjoyed the insights.",
            CreatedOn = currentDate.AddDays(-2),
            UserProfileId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",
            PostId = 1
        },
        new Comment
        {
            Id = 2,
            Body = "Thanks for sharing this information.",
            CreatedOn = currentDate.AddDays(-1),
            UserProfileId = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",
            PostId = 2
        },
        new Comment
        {
            Id = 3,
            Body = "This was very helpful. Looking forward to more updates!",
            CreatedOn = currentDate.AddDays(-3),
            UserProfileId = "0f6a348a-760e-4f67-8a72-fb1397b43f23",
            PostId = 3
        },
        new Comment
        {
            Id = 4,
            Body = "I disagree with some of the points mentioned.",
            CreatedOn = currentDate.AddDays(-4),
            UserProfileId = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",
            PostId = 4
        },
        new Comment
        {
            Id = 5,
            Body = "Can you provide more details on this topic?",
            CreatedOn = currentDate.AddDays(-5),
            UserProfileId = "ed677356-50e3-4640-8077-99db7f391a5b",
            PostId = 5
        },
        new Comment
        {
            Id = 6,
            Body = "Amazing content! Keep up the great work.",
            CreatedOn = currentDate.AddDays(-6),
            UserProfileId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",
            PostId = 6
        },
        new Comment
        {
            Id = 7,
            Body = "Very informative, but could use some examples.",
            CreatedOn = currentDate.AddDays(-7),
            UserProfileId = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",
            PostId = 7
        },
        new Comment
        {
            Id = 8,
            Body = "Nice article. I learned something new today!",
            CreatedOn = currentDate.AddDays(-8),
            UserProfileId = "0f6a348a-760e-4f67-8a72-fb1397b43f23",
            PostId = 8
        },
        new Comment
        {
            Id = 9,
            Body = "Good read, but could be more concise.",
            CreatedOn = currentDate.AddDays(-9),
            UserProfileId = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",
            PostId = 9
        },
        new Comment
        {
            Id = 10,
            Body = "Interesting perspective, thanks for sharing!",
            CreatedOn = currentDate.AddDays(-10),
            UserProfileId = "ed677356-50e3-4640-8077-99db7f391a5b",
            PostId = 10
        }
    );


        //seeding follow relationships
        builder.Entity<Follow>().HasData(
        // User 'Admin' follows other users
        new Follow
        {
            Id = 1,
            FollowerUserId = "ed677356-50e3-4640-8077-99db7f391a5b", // Admin
            FolloweeUserId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6"  // DevUser
        },
        new Follow
        {
            Id = 2,
            FollowerUserId = "ed677356-50e3-4640-8077-99db7f391a5b", // Admin
            FolloweeUserId = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb"  // DesignGuru
        },

        // User 'DevUser' follows other users
        new Follow
        {
            Id = 3,
            FollowerUserId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", // DevUser
            FolloweeUserId = "0f6a348a-760e-4f67-8a72-fb1397b43f23"  // Marketer
        },
        new Follow
        {
            Id = 4,
            FollowerUserId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", // DevUser
            FolloweeUserId = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b"  // SupportTech
        },

        // User 'DesignGuru' follows other users
        new Follow
        {
            Id = 5,
            FollowerUserId = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", // DesignGuru
            FolloweeUserId = "ed677356-50e3-4640-8077-99db7f391a5b"  // Admin
        },
        new Follow
        {
            Id = 6,
            FollowerUserId = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", // DesignGuru
            FolloweeUserId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6"  // DevUser
        },

        // User 'Marketer' follows other users
        new Follow
        {
            Id = 7,
            FollowerUserId = "0f6a348a-760e-4f67-8a72-fb1397b43f23", // Marketer
            FolloweeUserId = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb"  // DesignGuru
        },
        new Follow
        {
            Id = 8,
            FollowerUserId = "0f6a348a-760e-4f67-8a72-fb1397b43f23", // Marketer
            FolloweeUserId = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b"  // SupportTech
        },

        // User 'SupportTech' follows other users
        new Follow
        {
            Id = 9,
            FollowerUserId = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", // SupportTech
            FolloweeUserId = "ed677356-50e3-4640-8077-99db7f391a5b"  // Admin
        },
        new Follow
        {
            Id = 10,
            FollowerUserId = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", // SupportTech
            FolloweeUserId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6"  // DevUser
        }
        );

        //seeding likes 
        builder.Entity<Like>().HasData(
            // Likes for Posts
            new Like
            {
                Id = 1,
                UserProfileId = "ed677356-50e3-4640-8077-99db7f391a5b", // Admin
                PostId = 1,
                CommentId = null,
                CreatedOn = currentDate.AddDays(-1)
            },
            new Like
            {
                Id = 2,
                UserProfileId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", // DevUser
                PostId = 2,
                CommentId = null,
                CreatedOn = currentDate.AddDays(-2)
            },
            new Like
            {
                Id = 3,
                UserProfileId = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", // DesignGuru
                PostId = 3,
                CommentId = null,
                CreatedOn = currentDate.AddDays(-3)
            },
            new Like
            {
                Id = 4,
                UserProfileId = "0f6a348a-760e-4f67-8a72-fb1397b43f23", // Marketer
                PostId = 4,
                CommentId = null,
                CreatedOn = currentDate.AddDays(-4)
            },
            new Like
            {
                Id = 5,
                UserProfileId = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", // SupportTech
                PostId = 5,
                CommentId = null,
                CreatedOn = currentDate.AddDays(-5)
            },

            // Likes for Comments
            new Like
            {
                Id = 6,
                UserProfileId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", // DevUser
                PostId = null,
                CommentId = 1,
                CreatedOn = currentDate.AddDays(-1)
            },
            new Like
            {
                Id = 7,
                UserProfileId = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", // DesignGuru
                PostId = null,
                CommentId = 2,
                CreatedOn = currentDate.AddDays(-2)
            },
            new Like
            {
                Id = 8,
                UserProfileId = "0f6a348a-760e-4f67-8a72-fb1397b43f23", // Marketer
                PostId = null,
                CommentId = 3,
                CreatedOn = currentDate.AddDays(-3)
            },
            new Like
            {
                Id = 9,
                UserProfileId = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", // SupportTech
                PostId = null,
                CommentId = 4,
                CreatedOn = currentDate.AddDays(-4)
            },
            new Like
            {
                Id = 10,
                UserProfileId = "ed677356-50e3-4640-8077-99db7f391a5b", // Admin
                PostId = null,
                CommentId = 5,
                CreatedOn = currentDate.AddDays(-5)
            }
        );

        //seeding notifications
        builder.Entity<Notification>().HasData(
            // Notifications for Likes on Posts
            new Notification
            {
                Id = 1,
                Type = NotificationType.Like,
                CreatedOn = currentDate.AddDays(-1),
                IsSeen = false,
                ToUserProfileId = "ed677356-50e3-4640-8077-99db7f391a5b", // Admin
                FromUserProfileId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",  // DevUser
                PostId = 1,
                CommentId = null
            },
            new Notification
            {
                Id = 2,
                Type = NotificationType.Like,
                CreatedOn = currentDate.AddDays(-2),
                IsSeen = false,
                ToUserProfileId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", // DevUser
                FromUserProfileId = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",  // DesignGuru
                PostId = 2,
                CommentId = null
            },
            new Notification
            {
                Id = 3,
                Type = NotificationType.Like,
                CreatedOn = currentDate.AddDays(-3),
                IsSeen = false,
                ToUserProfileId = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", // DesignGuru
                FromUserProfileId = "0f6a348a-760e-4f67-8a72-fb1397b43f23",  // Marketer
                PostId = 3,
                CommentId = null
            },
            new Notification
            {
                Id = 4,
                Type = NotificationType.Like,
                CreatedOn = currentDate.AddDays(-4),
                IsSeen = false,
                ToUserProfileId = "0f6a348a-760e-4f67-8a72-fb1397b43f23", // Marketer
                FromUserProfileId = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",  // SupportTech
                PostId = 4,
                CommentId = null
            },
            new Notification
            {
                Id = 5,
                Type = NotificationType.Like,
                CreatedOn = currentDate.AddDays(-5),
                IsSeen = false,
                ToUserProfileId = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", // SupportTech
                FromUserProfileId = "ed677356-50e3-4640-8077-99db7f391a5b",  // Admin
                PostId = 5,
                CommentId = null
            },

            // Notifications for Likes on Comments
            new Notification
            {
                Id = 6,
                Type = NotificationType.Like,
                CreatedOn = currentDate.AddDays(-1),
                IsSeen = false,
                ToUserProfileId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6", // DevUser
                FromUserProfileId = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb",  // DesignGuru
                PostId = null,
                CommentId = 1
            },
            new Notification
            {
                Id = 7,
                Type = NotificationType.Like,
                CreatedOn = currentDate.AddDays(-2),
                IsSeen = false,
                ToUserProfileId = "4d1cf4a5-4e5d-43d5-bb1d-22a5b0c85dcb", // DesignGuru
                FromUserProfileId = "0f6a348a-760e-4f67-8a72-fb1397b43f23",  // Marketer
                PostId = null,
                CommentId = 2
            },
            new Notification
            {
                Id = 8,
                Type = NotificationType.Like,
                CreatedOn = currentDate.AddDays(-3),
                IsSeen = false,
                ToUserProfileId = "0f6a348a-760e-4f67-8a72-fb1397b43f23", // Marketer
                FromUserProfileId = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b",  // SupportTech
                PostId = null,
                CommentId = 3
            },
            new Notification
            {
                Id = 9,
                Type = NotificationType.Like,
                CreatedOn = currentDate.AddDays(-4),
                IsSeen = false,
                ToUserProfileId = "a87b2e1e-39a4-4fd1-8237-f013f4e9cf6b", // SupportTech
                FromUserProfileId = "ed677356-50e3-4640-8077-99db7f391a5b",  // Admin
                PostId = null,
                CommentId = 4
            },
            new Notification
            {
                Id = 10,
                Type = NotificationType.Like,
                CreatedOn = currentDate.AddDays(-5),
                IsSeen = false,
                ToUserProfileId = "ed677356-50e3-4640-8077-99db7f391a5b", // Admin
                FromUserProfileId = "b31adf09-b1f4-4f2d-bb02-6d1e9f7c65b6",  // DevUser
                PostId = null,
                CommentId = 5
            }
        );
    }
}
