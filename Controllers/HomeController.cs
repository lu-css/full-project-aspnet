using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using tcc.Areas.Identity.Data;

namespace tcc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly UserManager<ApplicationUser> _userManager;


    public HomeController(UserManager<ApplicationUser> userManager, ILogger<HomeController> logger)
    {
        _logger = logger;
        _userManager = userManager;
    }

    public IActionResult Index()
    {
        return View();
    }

    [Authorize]
    public async Task<IActionResult> Info()
    {
        var user = await _userManager.GetUserAsync(User);

        return View(user);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
