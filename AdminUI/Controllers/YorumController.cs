using AdminUI.Models;
using ApiAccess.Absract;
using ApiAccess.Base;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;

namespace AdminUI.Controllers
{
    public class YorumController : Controller
    {
        private readonly IYorumApiRequest _yorumApiRequest;
        public YorumController(IYorumApiRequest yorumApiRequest)
        {
            _yorumApiRequest = yorumApiRequest;
        }

        public IActionResult Index()
        {
            List<YorumlarDto> pageData = _yorumApiRequest.GetTumYorumlar();
            return View(pageData);
        }

        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YorumEkle(YorumViewModel model)
        {
            YorumlarDto yorum = new YorumlarDto();
            yorum.Name = model.Name;
            yorum.Surname = model.Surname;
            yorum.Email = model.Email;
            yorum.Baslik = model.Baslik;
            yorum.Icerik = model.Icerik;
            yorum.HaberId = model.HaberId;
            yorum.AktifMi = model.AktifMi;

            var insertData = _yorumApiRequest.InsertYorum(yorum);
            return RedirectToAction("Index");
        }

        public IActionResult Guncelle(int yorumId)
        {
            var model = _yorumApiRequest.GetYorumById(yorumId);
            YorumViewModel yorum = new YorumViewModel();
            yorum.Id = model.Id;
            yorum.Name = model.Name;
            yorum.Surname = model.Surname;
            yorum.Email = model.Email;
            yorum.Baslik = model.Baslik;
            yorum.Icerik = model.Icerik;
            yorum.HaberId = model.HaberId;
            yorum.AktifMi = model.AktifMi;
            return View(yorum);
        }

        [HttpPost]
        public IActionResult YorumGuncelle(YorumViewModel model)
        {
            YorumlarDto yorum = new YorumlarDto();
            yorum.Id = model.Id;
            yorum.Name = model.Name;
            yorum.Surname = model.Surname;
            yorum.Email = model.Email;
            yorum.Baslik = model.Baslik;
            yorum.Icerik = model.Icerik;
            yorum.HaberId = model.HaberId;
            yorum.AktifMi = model.AktifMi;

            _yorumApiRequest.UpdateYorum(yorum);
            return RedirectToAction("Index");

        }

        public IActionResult Sil(int yorumId)
        {
            _yorumApiRequest.DeleteYorum(yorumId);
            return RedirectToAction("Index");
        }

    }
}
