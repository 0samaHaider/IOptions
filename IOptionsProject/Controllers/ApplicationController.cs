using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace IOptionsProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ApplicationController : ControllerBase
{
    private readonly AppSettings _appSettings;

    public ApplicationController(IOptions<AppSettings> appSettings) => _appSettings = appSettings.Value;

    [HttpGet("GetAppData")]
    public IActionResult GetAppData()
    {
        var appName = _appSettings.AppName;
        var appVersion = _appSettings.AppVersion;

        var appData = "App Name: " + appName + " And App Version: " + appVersion;
        return Ok(appData);
    }
}