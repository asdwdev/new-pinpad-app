using Microsoft.AspNetCore.Mvc;
using NewPinpadApp.Attributes;

namespace NewPinpadApp.Controllers
{
    public class ResponseLogController : Controller
    {
        [RequireApiSession]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
