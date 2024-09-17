using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Dto.Profile;
public class UpdateProfileDto
{
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Bio { get; set; }
    public string? Website { get; set; }
    public string? ProfilePictureName { get; set; }
    public IFormFile? ProfilePictureFile { get; set; }
}
