using CoffylabMVCProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.ViewComponents
{
    public class _DefaultHeaderComponentPartial : ViewComponent
    {

        private readonly CoffylabContext _context;

        public _DefaultHeaderComponentPartial(CoffylabContext context)
        {
            _context = context;
        }

       public IViewComponentResult Invoke()
        {
            ViewBag.Location = _context.Tbl_Header.Select(x => x.Location).FirstOrDefault();
            ViewBag.OpenHoursWeekdays = _context.Tbl_Header.Select(x => x.OpenHoursWeekdays).FirstOrDefault();
            ViewBag.OpenHoursWeekends = _context.Tbl_Header.Select(x => x.OpenHoursWeekends).FirstOrDefault();
            ViewBag.PhoneNumber = _context.Tbl_Header.Select(x => x.PhoneNumber).FirstOrDefault();
            return View();
        }
    }
}
