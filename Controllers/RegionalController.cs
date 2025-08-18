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

        [RequireApiSession]
        public IActionResult Edit(int id)
        {
            ViewBag.Id = id; // supaya bisa dipakai di view buat fetch data API
            return View();
            // return View("Update"); // kalau nama view-nya Update.cshtml
        }
    }
}