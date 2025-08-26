using Microsoft.AspNetCore.Mvc;
using NewPinpadApp.Attributes;

namespace NewPinpadApp.Controllers
{
  public class UserController : Controller
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

    public IActionResult Edit(int id)
    {
      ViewBag.Id = id;
      return View();
    }
  }
}