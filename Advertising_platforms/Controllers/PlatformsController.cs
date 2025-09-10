using AdPlatformsService.Bll.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdPlatformsService.Api.Controllers;

[ApiController]
[Route("api/platforms")]
public class PlatformsController : ControllerBase
{
    private readonly IPlatformService _platformService;

    public PlatformsController(IPlatformService platformService)
    {
        _platformService = platformService;
    }

    [HttpGet("search")]
    public IActionResult Search([FromQuery] string location)
    {
        var platforms = _platformService.Search(location);
        return Ok(platforms);
    }
}
