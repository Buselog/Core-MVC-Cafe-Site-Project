using CoffylabMVCProject.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffylabMVCProject.ViewComponents
{
    public class _AdminLayoutNavbarComponentPartial : ViewComponent
    {
        private readonly CoffylabContext _context;
        public _AdminLayoutNavbarComponentPartial(CoffylabContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.LastRequestCount = _context.Tbl_Subscribe.Where(x => x.ApprovalStatus == false).Count();
            ViewBag.LastSubscribeRequests = _context.Tbl_Subscribe.Where(x => x.ApprovalStatus == false).OrderByDescending(x => x.SubscribeId).Take(4).ToList();

            ViewBag.UnreadNotificationCount = _context.Tbl_Notification.Where(x => x.IsRead == false).Count();
            ViewBag.LastNotifications = _context.Tbl_Notification.OrderByDescending(x => x.NotificationId).Take(3).ToList();
            return View();
        }
    }
}
