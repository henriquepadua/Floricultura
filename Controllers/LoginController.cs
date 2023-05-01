using Microsoft.AspNetCore.Mvc;

namespace Floricultura.Controllers
{
    public class LoginController : Controller
    {
        [AcceptVerbs("GET", "POST")]
        [Route("Login")]
        public async Task<IActionResult> Index()
        {
               return View();
        }
    }
}
