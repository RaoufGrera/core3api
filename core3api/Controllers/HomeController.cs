using Microsoft.AspNetCore.Mvc;

namespace core3api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return new RedirectResult("~/swagger/");
        }
    }
}
