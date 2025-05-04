using CoffylabMVCProject.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffylabMVCProject.ViewComponents
{
    public class _DefaultMenuComponentPartial : ViewComponent
    {
        private readonly CoffylabContext _context;

        public _DefaultMenuComponentPartial(CoffylabContext context)
        {
            _context = context;
        }

        // Eager Loading
        public IViewComponentResult Invoke()
        {
            var values = _context.Tbl_Product.Include(x => x.Category).ToList();
            ViewBag.Categories =  _context.Tbl_Category.ToList();
            return View(values);
        }

    }
}
