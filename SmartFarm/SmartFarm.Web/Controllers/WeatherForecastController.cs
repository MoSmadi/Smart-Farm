using Microsoft.AspNetCore.Mvc;

namespace SmartFarm.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class MainSmartFarmController : ControllerBase
{
    private readonly ILogger<MainSmartFarmController> _logger;

    public MainSmartFarmController(ILogger<MainSmartFarmController> logger)
    {
        _logger = logger;
    }
}