using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ContructorFinder.Models;

namespace ContructorFinder.Controllers;


public class AdminController : Controller
{
    private readonly ILogger<AdminController> _logger;

    public AdminController(ILogger<AdminController> logger)
    {
        _logger = logger;
    }



    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Acc_New()
    {
        return View(ViewData["signState"] = true);
    }

    public IActionResult Acc_Auth(string username,string password)
    {
        if(username == "Jake")
        {
        return View();
        }else
        {
        return View();
        }

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}


