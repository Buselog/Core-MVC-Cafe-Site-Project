using CoffylabMVCProject.Context;
using CoffylabMVCProject.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace CoffylabMVCProject.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminDashboardCardComponentPartial : ViewComponent
    {
        private readonly CoffylabContext _context;
        public _AdminDashboardCardComponentPartial(CoffylabContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.CoffeeCount = _context.Tbl_Product.Where(x => x.Category.CategoryId == 1).Count();
            ViewBag.LastAddedProduct = _context.Tbl_Product.OrderByDescending(x => x.ProductId).Select(x=>x.ProductName).FirstOrDefault();

            ViewBag.CoffeePriceAverage = _context.Tbl_Product.Select(x => x.ProductPrice).Average().ToString("F2", CultureInfo.InvariantCulture);
            ViewBag.LastAddedProductPrice = _context.Tbl_Product.OrderByDescending(x => x.ProductId).Select(x => x.ProductPrice).FirstOrDefault();

            ViewBag.WaitingSubscribesRequestCount = _context.Tbl_Subscribe.Where(x => x.ApprovalStatus == false).Count();
            ViewBag.ApprovedSubscribeCount = _context.Tbl_Subscribe.Where(x => x.ApprovalStatus == true).Count();
            return View();
        }

    }
}
