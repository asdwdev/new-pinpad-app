using Microsoft.AspNetCore.Mvc;
namespace NewPinpadApp.Controllers;
using NewPinpadApp.Attributes;


public class DashboardController : Controller
{

    [RequireApiSession]
    public IActionResult Index()
    {
        return View();
    }
}