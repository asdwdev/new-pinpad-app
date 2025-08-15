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

    public async Task<IActionResult> Edit(int id)
    {
        // var client = new HttpClient();
        // var response = await client.GetAsync($"http://localhost:5125/api/pinpads/inquiry?page=1&size=1000&q={id}");

        // if (!response.IsSuccessStatusCode)
        //     return NotFound();

        // var json = await response.Content.ReadAsStringAsync();

        // using var doc = JsonDocument.Parse(json);
        // var root = doc.RootElement;

        // // Gunakan nama property sesuai JSON: "data"
        // if (!root.TryGetProperty("data", out var dataArray) || dataArray.GetArrayLength() == 0)
        //     return NotFound(); // Kalau data kosong, kembalikan 404

        // var pinpad = dataArray[0];
        // ViewBag.Pinpad = new
        // {
        //     Id = pinpad.GetProperty("id").GetInt32(),
        //     Branch = pinpad.GetProperty("branch").GetString(),
        //     SerialNumber = pinpad.GetProperty("serialNumber").GetString(),
        //     Status = pinpad.GetProperty("status").GetString(),
        //     RegisterDate = pinpad.GetProperty("registerDate").GetString()
        // };

        return View();
    }
}
