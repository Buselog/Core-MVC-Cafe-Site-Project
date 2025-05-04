using CoffylabMVCProject.Context;
using CoffylabMVCProject.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CoffylabMVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly CoffylabContext _context;

        public ProductController(CoffylabContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.Tbl_Product.Include(x => x.Category).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddNewProduct()
        {

            List<SelectListItem> categories = (from x in _context.Tbl_Category.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString()

                                               }
                                               ).ToList();

            ViewBag.Categories = categories;
            return View();

        }

        [HttpPost]
        public IActionResult AddNewProduct(Product addedProduct)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> categories = _context.Tbl_Category
           .Select(x => new SelectListItem
           {
               Text = x.CategoryName,
               Value = x.CategoryId.ToString()
           }).ToList();
                ViewBag.Categories = categories;

                return View(addedProduct);
            }
            if (addedProduct.ImageFile != null)
            {


                //Uygulamanın çalıştığı dizini al:
                var currentDirectory = Directory.GetCurrentDirectory();

                //Uygulamanın uzantısını al(jpg, png):
                var extension = Path.GetExtension(addedProduct.ImageFile.FileName);

                //Benzersiz bir dosya adı oluştur:
                var fileName = Guid.NewGuid().ToString();

                //Kaydedilecek dosyanın yolunu oluştur:
                var saveLocation = Path.Combine(currentDirectory, "wwwroot/images", fileName + extension);

                //Belirtilen konumda bir dosya oluşturur:
                //Fiziksel olarak dosya oluşturmaz ❌
                //Sadece "dosya buraya kaydedilecek" bilgisini hazırlar ✅
                var stream = new FileStream(saveLocation, FileMode.Create);
                //O dosya yolunda fiziksel olarak dosyayı açar/oluşturur


                //Dosyayı fiziksel olarak sunucuya yaz:
                addedProduct.ImageFile.CopyTo(stream);
                //Dosyanın içeriğini yazar(yani resmi gerçekten kaydeder)


                addedProduct.ImageUrl = "/images/" + fileName + extension;
            }

            _context.Tbl_Product.Add(addedProduct);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            List<SelectListItem> categories = (from x in _context.Tbl_Category.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString()

                                               }
                                               ).ToList();

            ViewBag.Categories = categories;
            var values = _context.Tbl_Product.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product updatedProduct)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> categories = _context.Tbl_Category
           .Select(x => new SelectListItem
           {
               Text = x.CategoryName,
               Value = x.CategoryId.ToString()
           }).ToList();
                ViewBag.Categories = categories;

                return View(updatedProduct);
            }

            if (updatedProduct.ImageFile != null)
            {
                //Uygulamanın çalıştığı dizini al:
                var currentDirectory = Directory.GetCurrentDirectory();

                //Uygulamanın uzantısını al(jpg, png):
                var extension = Path.GetExtension(updatedProduct.ImageFile.FileName);

                //Benzersiz bir dosya adı oluştur:
                var fileName = Guid.NewGuid().ToString();

                //Kaydedilecek dosyanın yolunu oluştur:
                var saveLocation = Path.Combine(currentDirectory, "wwwroot/images", fileName + extension);

                //Belirtilen konumda bir dosya oluşturur:
                //Fiziksel olarak dosya oluşturmaz ❌
                //Sadece "dosya buraya kaydedilecek" bilgisini hazırlar ✅
                var stream = new FileStream(saveLocation, FileMode.Create);
                //O dosya yolunda fiziksel olarak dosyayı açar/oluşturur


                //Dosyayı fiziksel olarak sunucuya yaz:
                updatedProduct.ImageFile.CopyTo(stream);
                //Dosyanın içeriğini yazar(yani resmi gerçekten kaydeder)


                updatedProduct.ImageUrl = "/images/" + fileName + extension;
            }

            _context.Tbl_Product.Update(updatedProduct);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            var values = _context.Tbl_Product.Find(id);
            _context.Tbl_Product.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }




    }
}
