using AdPlatformsService.Bll.Interfaces;
using Microsoft.AspNetCore.Http;

namespace AdPlatformsService.Dal;

public class FilePlatformLoader
{
    private readonly IPlatformService _platformService;

    public FilePlatformLoader(IPlatformService platformService)
    {
        _platformService = platformService;
    }

    public void Load(IFormFile file)
    {
        var filePath = Path.GetTempFileName();
        using (var stream = File.Create(filePath))
        {
            file.CopyTo(stream);
        }

        _platformService.LoadFromFile(filePath);
    }
}
