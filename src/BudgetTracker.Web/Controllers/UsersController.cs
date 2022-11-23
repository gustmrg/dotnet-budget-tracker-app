using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BudgetTracker.Web.Controllers;

[Authorize]
public class UsersController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    // GET
    public IActionResult Roles()
    {
        return View();
    }
}