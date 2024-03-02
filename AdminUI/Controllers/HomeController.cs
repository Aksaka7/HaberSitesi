using ApiAccess.Absract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminUI.Controllers
{


    public class HomeController : Controller
    {
        private readonly IHaberApiRequest _haberApiRequest;
        public HomeController(IHaberApiRequest haberApiRequest)
        {
            _haberApiRequest = haberApiRequest;
        }

        public IActionResult Index()
        {
            var haberler = _haberApiRequest.GetHaberler();
            return View(haberler);
        }

        public IActionResult ActionResult()
        {
            return View();
        }
    }
}
