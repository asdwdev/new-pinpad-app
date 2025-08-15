using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using NewPinpadApp.Models;

namespace NewPinpadApp.Controllers;


public class PinpadController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("me")]
    public IActionResult Me()
    {
        var userId = HttpContext.Session.GetInt32("UserId");
        if (userId == null)
        {
            return Unauthorized(new { success = false, message = "Not logged in" });
        }

        var username = HttpContext.Session.GetString("Username");
        var role = HttpContext.Session.GetString("Role");
        return Ok(new { success = true, username, role });
    }

    public IActionResult Edit(int id)
    {
        ViewBag.Id = id;            // atau pakai model strongly-typed
        return View();
    }
}
