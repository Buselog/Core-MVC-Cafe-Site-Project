using CoffylabMVCProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.ViewComponents
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {
        private readonly CoffylabContext _context;

        public _DefaultTestimonialComponentPartial(CoffylabContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Tbl_Testimonial.ToList();
            return View(values);
        }
    }
}
