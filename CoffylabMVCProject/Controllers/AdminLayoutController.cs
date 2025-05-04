using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
