using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NewPinpadApp.Models;
namespace NewPinpadApp.Controllers;

public class AuthController : Controller
{
    public IActionResult Login()
    {
        return View();
    }
}
