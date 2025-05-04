using CoffylabMVCProject.Context;
using CoffylabMVCProject.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly CoffylabContext _context;

        public CategoryController(CoffylabContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Tbl_Category.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddNewCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewCategory(Category addedNewCategory)
        {
            if (!ModelState.IsValid) return View(addedNewCategory);
            _context.Tbl_Category.Add(addedNewCategory);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id)
        {
            var values = _context.Tbl_Category.Find(id);
            _context.Tbl_Category.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var values = _context.Tbl_Category.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category updatedCategory)
        {
            // MVC'de;
            //var values = _context.Tbl_Category.Find(updatedCategory.CategoryId);
            //values.CategoryName = updatedCategory.CategoryName;

            if (!ModelState.IsValid) return View(updatedCategory);
            _context.Tbl_Category.Update(updatedCategory);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
