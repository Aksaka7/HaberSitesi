using AdminUI.Models;
using ApiAccess.Absract;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AdminUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IYazarApiRequest _yazarApiRequest;
        public AccountController(IYazarApiRequest yazarApiRequest)
        {
            _yazarApiRequest = yazarApiRequest;
        }

        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> GirisYap(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var yazar = _yazarApiRequest.GetYazarByEmailPassword(model.Email, model.Password);
                if (yazar != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Email, model.Email)
                    };
                    var identity = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ModelState.AddModelError("ozelHataMesaji", "Kullanıcı veya şifre hatalı");
                    return View("Login");
                }
            }
            else
            {
                return View("Login");
            }

        }

        public async Task<IActionResult> CikisYap()
        {
            await HttpContext.SignOutAsync();
            return View("Login");

        }

    }
}
