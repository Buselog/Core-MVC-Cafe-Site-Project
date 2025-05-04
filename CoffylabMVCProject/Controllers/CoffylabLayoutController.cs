using CoffylabMVCProject.Context;
using CoffylabMVCProject.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.Controllers
{
    public class CoffylabLayoutController : Controller
    {
        // Index() ActionResult üzerine sağ tıklanıp Add View yapmamızı sağlayan şey Controller içinde olmamızdır.

        private readonly CoffylabContext _context;
        public CoffylabLayoutController(CoffylabContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubscribeRequest(Subscribe request)
        {
            if (!ModelState.IsValid) return RedirectToAction("Index");
            request.SendDate = DateTime.Now;
            request.ApprovalStatus = false;
            _context.Tbl_Subscribe.Add(request);
            _context.SaveChanges();
            return RedirectToAction("Index", "CoffylabLayout" ,new { success = true});
        }
    }
}
