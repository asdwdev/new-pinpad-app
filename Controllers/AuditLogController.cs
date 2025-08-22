using Microsoft.AspNetCore.Mvc;
using NewPinpadApp.Attributes;

namespace NewPinpadApp.Controllers
{
    public class AuditLogController : Controller
    {
        [RequireApiSession]
        public IActionResult Index()
        {
            return View();
        }
    }
}
