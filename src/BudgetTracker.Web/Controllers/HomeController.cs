﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BudgetTracker.Web.Models;
using Microsoft.AspNetCore.Authorization;

namespace BudgetTracker.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        if (User.Identity.IsAuthenticated)
        {
            return RedirectToAction("Dashboard", "Home");
        }
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    [Authorize]
    public IActionResult Dashboard()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}