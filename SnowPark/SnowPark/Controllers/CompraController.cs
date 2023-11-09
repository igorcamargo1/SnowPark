using Microsoft.AspNetCore.Mvc;

namespace SnowPark.Controllers;

public class CompraController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
