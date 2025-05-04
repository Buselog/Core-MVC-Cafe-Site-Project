using CoffylabMVCProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.ViewComponents
{
    public class _DefaultStatisticComponentPartial : ViewComponent
    {
        private readonly CoffylabContext _context;

        public _DefaultStatisticComponentPartial(CoffylabContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.ProductCount = _context.Tbl_Product.Count();
            ViewBag.CategoryCount = _context.Tbl_Category.Count();
            ViewBag.TestimonialCount = _context.Tbl_Testimonial.Count();
            ViewBag.SubscriberCount = _context.Tbl_Subscribe.Where(x=>x.ApprovalStatus==true).Count();
            return View();
        }
    }
}
