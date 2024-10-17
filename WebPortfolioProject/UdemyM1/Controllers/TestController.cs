using Microsoft.AspNetCore.Mvc;

namespace UdemyM1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
