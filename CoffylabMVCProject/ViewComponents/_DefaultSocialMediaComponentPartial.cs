using CoffylabMVCProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.ViewComponents
{
    public class _DefaultSocialMediaComponentPartial : ViewComponent
    {
        private readonly CoffylabContext _context;

        public _DefaultSocialMediaComponentPartial(CoffylabContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Tbl_SocialMedia.ToList();
            return View(values);
        }
    }
}
