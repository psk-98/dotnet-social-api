using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace dotnet_social_api.Models;

public class UserProfile : IdentityUser
{
    public string Bio { get; set; } = string.Empty;
}
