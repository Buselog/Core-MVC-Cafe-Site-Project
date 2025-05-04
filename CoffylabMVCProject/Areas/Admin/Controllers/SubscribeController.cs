using CoffylabMVCProject.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SubscribeController : Controller
    {
        private readonly CoffylabContext _context;

        public SubscribeController(CoffylabContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Tbl_Subscribe.OrderByDescending(x => x.SubscribeId).ToList();
            return View(values);
        }

        [HttpPost]
        public IActionResult ChangeApprovalStatus(int id)
        {
            var subscribeRequest = _context.Tbl_Subscribe.Find(id);
            subscribeRequest.ApprovalStatus = !subscribeRequest.ApprovalStatus;

            _context.Tbl_Subscribe.Update(subscribeRequest);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

