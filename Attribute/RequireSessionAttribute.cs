using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace NewPinpadApp.Attributes
{
    public class RequireApiSessionAttribute : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var path = context.HttpContext.Request.Path.Value?.ToLower();

            // Skip untuk halaman login
            if (path != null && (path.Contains("/auth/login") || path.Contains("/home/index")))
            {
                await next();
                return;
            }

            var handler = new HttpClientHandler
            {
                UseCookies = true,
                CookieContainer = new CookieContainer()
            };

            var apiUrl = "http://localhost:5125"; // sesuaikan sama API
            if (context.HttpContext.Request.Cookies.TryGetValue(".NewPinpad.Session", out var cookieValue))
            {
                handler.CookieContainer.Add(new Uri(apiUrl), new Cookie(".NewPinpad.Session", cookieValue));
            }

            using var client = new HttpClient(handler) { BaseAddress = new Uri(apiUrl) };
            var response = await client.GetAsync("/api/auth/me");

            if (!response.IsSuccessStatusCode)
            {
                context.Result = new RedirectToActionResult("Login", "Auth", null);
                return;
            }

            await next();
        }
    }
}
