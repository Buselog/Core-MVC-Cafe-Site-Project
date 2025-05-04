using CoffylabMVCProject.Context;
using CoffylabMVCProject.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class GalleryController : Controller
    {
        private readonly CoffylabContext _context;

        public GalleryController(CoffylabContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Tbl_Gallery.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddNewImage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewImage(Gallery addedNewImage)
        {
            _context.Tbl_Gallery.Add(addedNewImage);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteImage(int id)
        {
            var values = _context.Tbl_Gallery.Find(id);
            _context.Tbl_Gallery.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateImage(int id)
        {
            var values = _context.Tbl_Gallery.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateImage(Gallery updatedImage)
        {
            _context.Tbl_Gallery.Update(updatedImage);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
