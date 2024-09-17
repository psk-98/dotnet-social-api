using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Interface;

public interface IProfilePictureService
{
    Task<string> SaveFileAsync(IFormFile file, string[] allowedFileExtensions);
    void DeleteFileAsync(string fileNameWithExtension);
}
