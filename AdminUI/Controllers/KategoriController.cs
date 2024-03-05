using AdminUI.Models;
using ApiAccess.Absract;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;

namespace AdminUI.Controllers
{
    public class KategoriController : Controller
    {
        private readonly IKategoriApiRequest _kategoriApiRequest;

        public KategoriController(IKategoriApiRequest kategoriApiRequest)
        {
            _kategoriApiRequest = kategoriApiRequest;
        }
        public IActionResult Index()
        {
            var pageData = _kategoriApiRequest.GetKategoriler();

            return View(pageData);
        }
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KategoriEkle(KategoriViewModel model)
        {
            KategorilerDto kategori = new()
            {
                AktifMi = model.AktifMi,
                Aciklama = model.Aciklama
            };
            _ = _kategoriApiRequest.KategoriEkle(kategori);

            return RedirectToAction("Index");
        }


        public IActionResult Guncelle(int kategoriId)
        {
            var data = _kategoriApiRequest.GetKategoriById(kategoriId); //Apideki Kategori Başlıgını aldım.

            KategoriViewModel model = new()
            {
                Id = data.Id,
                AktifMi = data.AktifMi,
                Aciklama = data.Aciklama
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult KategoriGuncelle(KategoriViewModel model)
        {
            KategorilerDto kategori = new()
            {
                Id = model.Id.Value,
                AktifMi = model.AktifMi,
                Aciklama = model.Aciklama
            };
            _kategoriApiRequest.UpdateKategori(kategori);
            return RedirectToAction("Index");
        }

        public IActionResult Sil(int kategoriId) // İlişkili olan taploları silemezsin.
        {
            _ = _kategoriApiRequest.DeleteKategori(kategoriId);
            return RedirectToAction("Index");
        }
    }
}
