using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Dto.Profile;

public class RegisterDto
{
    [Required]
    public string? UserName { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 100 characters")]
    public string? Password { get; set; }
}