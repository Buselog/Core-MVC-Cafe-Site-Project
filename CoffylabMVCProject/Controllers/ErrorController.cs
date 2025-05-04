using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/404")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
