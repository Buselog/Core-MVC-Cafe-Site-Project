using CoffylabMVCProject.Context;
using CoffylabMVCProject.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffylabMVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AddressController : Controller
    {
        private readonly CoffylabContext _context;

        public AddressController(CoffylabContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value = _context.Tbl_Header.Where(x => x.HeaderId == 1).ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult UpdateAddress(int id)
        {
            var values = _context.Tbl_Header.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAddress(Header updatedAddress)
        {
            if (!ModelState.IsValid) return View(updatedAddress);
            _context.Tbl_Header.Update(updatedAddress);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
