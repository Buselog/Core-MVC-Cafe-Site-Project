using CoffylabMVCProject.Context;
using CoffylabMVCProject.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.ViewComponents
{
    public class _AdminLayoutSidebarComponentPartial : ViewComponent
    {
        private readonly CoffylabContext _context;
        public _AdminLayoutSidebarComponentPartial(CoffylabContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
