using CoffylabMVCProject.Context;
using CoffylabMVCProject.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProfileController : Controller
    {
        private readonly CoffylabContext _context;

        public ProfileController(CoffylabContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult Index()
        {
            var adminId = HttpContext.Session.GetInt32("adminId");
            if (adminId == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var values = _context.Tbl_Admin.FirstOrDefault(x => x.AdminId == adminId);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Admin updatedAdmin)
        {
            if (!ModelState.IsValid) return View(updatedAdmin);
            _context.Tbl_Admin.Update(updatedAdmin);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(Admin updatedAdmin)
        {
            if (!ModelState.IsValid) return View(updatedAdmin);

            var values = _context.Tbl_Admin.FirstOrDefault(x => x.AdminId == HttpContext.Session.GetInt32("adminId"));
            if (values.password != updatedAdmin.CurrentPassword)
            {
                ModelState.AddModelError("", "Current password is incorrect");
                return View(updatedAdmin);
            }
            if (updatedAdmin.NewPassword != updatedAdmin.ConfirmPassword)
            {
                ModelState.AddModelError("", "Passwords do not match");
                return View(updatedAdmin);
            }

            values.password = updatedAdmin.NewPassword;
            _context.SaveChanges();
            return RedirectToAction("LogOut", "Login");
        }
    }
}
