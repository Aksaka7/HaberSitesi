using ApiAccess.Absract;
using Microsoft.AspNetCore.Mvc;

namespace AdminUI.Controllers
{
    public class HaberController : Controller
    {
        private readonly IHaberApiRequest _haberApiRequest;
        public HaberController(IHaberApiRequest haberApiRequest)
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
