using AdPlatformsService.Dal;
using Microsoft.AspNetCore.Mvc;

namespace AdPlatformsService.Api.Controllers;

[ApiController]
[Route("api/platforms")]
public class UploadController : ControllerBase
{
    private readonly FilePlatformLoader _loader;
    public UploadController(FilePlatformLoader loader) => _loader = loader;

    [HttpPost("upload")]
    public IActionResult Upload(IFormFile file)
    {
        if (file == null || file.Length == 0)
            return BadRequest("Файл пустой");

        _loader.Load(file);
        return Ok("Данные загружены");
    }
}
