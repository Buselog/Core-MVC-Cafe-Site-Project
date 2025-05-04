using CoffylabMVCProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.ViewComponents
{
    public class _DefaultGalleryComponentPartial : ViewComponent
    {
        private readonly CoffylabContext _context;

        public _DefaultGalleryComponentPartial(CoffylabContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.FirstTwoImages = _context.Tbl_Gallery.OrderBy(x => x.GalleryId).Take(2).ToList();
            ViewBag.ThirdImage = _context.Tbl_Gallery.Where(x => x.GalleryId == 3).Select(x => x.ImageUrl).FirstOrDefault();
            ViewBag.LastTwoImages = _context.Tbl_Gallery.OrderByDescending(x => x.GalleryId).Take(2).ToList();
            return View();
        }
    }
}
