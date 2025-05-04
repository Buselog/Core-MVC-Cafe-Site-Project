using CoffylabMVCProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.ViewComponents
{
    public class _DefaultVideoComponentPartial : ViewComponent
    {

        private readonly CoffylabContext _context;

        public _DefaultVideoComponentPartial(CoffylabContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Tbl_Meet.ToList();
            return View(values);
        }
    }
}
