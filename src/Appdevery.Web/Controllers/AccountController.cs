using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Appdevery.Web.Controllers
{
    public class AccountController : Controller
    {
        public async Task Logout()
        {
            await HttpContext.Authentication.SignOutAsync("Cookies");
            await HttpContext.Authentication.SignOutAsync("oidc");
        }
    }
}