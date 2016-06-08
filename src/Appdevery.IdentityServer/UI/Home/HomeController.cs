using Microsoft.AspNetCore.Mvc;

namespace Appdevery.IdentityServer.UI.Home
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}