using Microsoft.AspNetCore.Mvc;

namespace HMISBMC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
