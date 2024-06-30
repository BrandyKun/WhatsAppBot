using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WhatsAppBot.Controllers;

[ApiController]
[Route("[controller]")]
public class WhatsappController : Controller
{
    private readonly ILogger<WhatsappController> _logger;

    public WhatsappController(ILogger<WhatsappController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}
