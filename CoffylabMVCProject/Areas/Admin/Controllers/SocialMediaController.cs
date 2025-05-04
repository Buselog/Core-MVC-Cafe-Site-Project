using CoffylabMVCProject.Context;
using CoffylabMVCProject.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SocialMediaController : Controller
    {
        private readonly CoffylabContext _context;

        public SocialMediaController(CoffylabContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Tbl_SocialMedia.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddNewSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewSocialMedia(SocialMedia addedNewSM)
        {
            if (!ModelState.IsValid) return View(addedNewSM);
            _context.Tbl_SocialMedia.Add(addedNewSM);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var values = _context.Tbl_SocialMedia.Find(id);
            _context.Tbl_SocialMedia.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var values = _context.Tbl_SocialMedia.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia updatedSM)
        {
            if (!ModelState.IsValid) return View(updatedSM);
            _context.Tbl_SocialMedia.Update(updatedSM);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}
