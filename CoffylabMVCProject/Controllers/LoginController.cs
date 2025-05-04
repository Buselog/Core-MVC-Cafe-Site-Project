using CoffylabMVCProject.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using CoffylabMVCProject.Context;

namespace CoffylabMVCProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly CoffylabContext _context;

        public LoginController(CoffylabContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(Admin admin)
        {

            var adminInfo = _context.Tbl_Admin
                .FirstOrDefault(x => x.Email == admin.Email && x.password == admin.password);

            if (adminInfo != null)
            {

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, adminInfo.Email),
                    new Claim("adminId", adminInfo.AdminId.ToString()),
                    new Claim("adminName", adminInfo.AdminName),
                    new Claim(ClaimTypes.Role, "Admin"),
                };


                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);


                var principal = new ClaimsPrincipal(identity);


                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                // 6- (İsteğe Bağlı) Session'a kullanıcı bilgilerini kaydet
                HttpContext.Session.SetInt32("adminId", adminInfo.AdminId);
                HttpContext.Session.SetString("adminEmail", adminInfo.Email);
                HttpContext.Session.SetString("adminName", adminInfo.AdminName);

                return RedirectToAction("Index", "Profile");
            }
            else
            {

                ModelState.AddModelError("", "Email or password is incorrect");
                return View();
            }
        }

        public async Task<IActionResult> LogOut()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
    }
}
