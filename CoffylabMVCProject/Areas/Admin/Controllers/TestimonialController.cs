using CoffylabMVCProject.Context;
using CoffylabMVCProject.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TestimonialController : Controller
    {
        private readonly CoffylabContext _context;

        public TestimonialController(CoffylabContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Tbl_Testimonial.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddNewTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewTestimonial(Testimonial addedNewTestimonial)
        {
            if (!ModelState.IsValid) return View(addedNewTestimonial);
            _context.Tbl_Testimonial.Add(addedNewTestimonial);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var values = _context.Tbl_Testimonial.Find(id);
            _context.Tbl_Testimonial.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var values = _context.Tbl_Testimonial.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial updatedTestimonial)
        {
            if (!ModelState.IsValid) return View(updatedTestimonial);
            _context.Tbl_Testimonial.Update(updatedTestimonial);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
