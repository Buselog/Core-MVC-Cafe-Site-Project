using CoffylabMVCProject.Context;
using CoffylabMVCProject.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AboutController : Controller
    {
        private readonly CoffylabContext _context;

        public AboutController(CoffylabContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.Tbl_Meet.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = _context.Tbl_Meet.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAbout(Meet updatedMeet)
        {
            if (!ModelState.IsValid) return View(updatedMeet);
            _context.Tbl_Meet.Update(updatedMeet);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
