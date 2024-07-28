using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SocialApi.Data;
using SocialApi.Models;

var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddDbContext<SocialContext>(opts => opts.UseSqlite(builder.Configuration.GetConnectionString("sqliteConnection")));

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<SocialContext>(opt => opt.UseSqlite("Data Source=social.db"));
builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<SocialContext>();
// .AddDefaultTokenProviders();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

app.Run("http://localhost:8500");
