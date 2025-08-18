using Microsoft.AspNetCore.Mvc;
using NewPinpadApp.Attributes;

namespace NewPinpadApp.Controllers
{
    public class RegionalController : Controller
    {
        [RequireApiSession]
        public IActionResult Index()
        {
            return View();
        }

        [RequireApiSession]
        public IActionResult Create()
        {
            return View();
        }
    }
}