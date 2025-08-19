using Microsoft.AspNetCore.Mvc;
using NewPinpadApp.Attributes;

namespace NewPinpadApp.Controllers
{
    public class BranchController : Controller
    {
        [RequireApiSession]
        public IActionResult Index()
        {
            return View();
        }

        [RequireApiSession]
        public IActionResult Edit(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}