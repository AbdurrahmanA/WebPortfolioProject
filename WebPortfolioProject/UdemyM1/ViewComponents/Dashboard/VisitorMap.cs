using Microsoft.AspNetCore.Mvc;

namespace UdemyM1.ViewComponents.Dashboard
{
    public class VisitorMap:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
