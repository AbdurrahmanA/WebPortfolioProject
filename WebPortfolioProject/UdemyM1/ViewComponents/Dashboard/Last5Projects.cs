using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UdemyM1.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}
