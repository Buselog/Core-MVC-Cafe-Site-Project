using CoffylabMVCProject.Context;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace CoffylabMVCProject.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminDashboardListComponentPartial : ViewComponent
    {
        private readonly CoffylabContext _context;
        public _AdminDashboardListComponentPartial(CoffylabContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Tbl_Subscribe.OrderByDescending(x => x.SubscribeId).Take(6).ToList();
            return View(values);
        }
    }
}
