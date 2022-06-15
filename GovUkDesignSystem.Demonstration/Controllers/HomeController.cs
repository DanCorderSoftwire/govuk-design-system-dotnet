using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GovUkDesignSystem.Demonstration.Models;

namespace GovUkDesignSystem.Demonstration.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("Index");
    }
    
    [HttpGet]
    public IActionResult Accordion()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult BackLink()
    {
        return View();
    }

    [HttpGet]
    public IActionResult TextInput()
    {
        return View(new TextInputDemoViewModel());
    }

    [HttpPost]
    public IActionResult TextInput(TextInputDemoViewModel demoViewModel)
    {
        if (!ModelState.IsValid)
        {
            return TextInput();
        }

        return Index();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
