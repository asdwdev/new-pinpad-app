using Microsoft.AspNetCore.Mvc;
namespace NewPinpadApp.Controllers;

public class MonitoringController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult PinpadLog()
    {
        return View();
    }

    public IActionResult TransactionLog()
    {
        return View();
    }
}