using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Interface;

namespace dotnet_social_api.Service;

public class ImageService : IImageService
{
    private readonly HttpContextAccessor _httpContextAccessor;
    private readonly IWebHostEnvironment _environment;
    public ImageService(IWebHostEnvironment environment, HttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
        _environment = environment;
    }

    public void DeleteFileAsync(string fileNameWithExtension)
    {
        if (string.IsNullOrEmpty(fileNameWithExtension)) throw new ArgumentNullException(nameof(fileNameWithExtension));

        var contentPath = _environment.ContentRootPath;
        var path = Path.Combine(contentPath, "Assets/img", fileNameWithExtension);

        if (!File.Exists(path)) throw new FileNotFoundException("Invalid file path");

        File.Delete(path);
    }

    public string GetImageBaseUrl()
    {
        var protocol = _httpContextAccessor.HttpContext.Request.Scheme;
        var host = _httpContextAccessor.HttpContext.Request.Host;
        string baseUrl = $"{protocol}://{host}/resources";

        return baseUrl;

    }

    public async Task<string> SaveFileAsync(IFormFile file, string[] allowedFileExtensions)
    {
        if (file == null) throw new ArgumentNullException(nameof(file));

        var contentPath = _environment.ContentRootPath;

        var path = Path.Combine(contentPath, "Assets/img");
        if (!Directory.Exists(path)) Directory.CreateDirectory(path);

        var ext = Path.GetExtension(file.FileName);
        if (!allowedFileExtensions.Contains(ext)) throw new ArgumentException($"Only {string.Join(",", allowedFileExtensions)} are allowed.");

        var fileName = $"{Guid.NewGuid().ToString()}{ext}";
        var fileNameWithPath = Path.Combine(path, fileName);
        using var stream = new FileStream(fileNameWithPath, FileMode.Create);
        await file.CopyToAsync(stream);

        return fileName;
    }


}
