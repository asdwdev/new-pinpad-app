using Microsoft.AspNetCore.Mvc;
namespace NewPinpadApp.Controllers;

public class MonitoringController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}