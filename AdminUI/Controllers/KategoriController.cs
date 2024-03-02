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
            KategorilerDto kategori = new KategorilerDto();
            kategori.AktifMi = model.AktifMi;
            kategori.Aciklama = model.Aciklama;
            var result = _kategoriApiRequest.KategoriEkle(kategori);

            return RedirectToAction("Index");
        }


        public IActionResult Guncelle(int kategoriId)
        {
            var data = _kategoriApiRequest.GetKategoriById(kategoriId); //Apideki Kategori Başlıgını aldım.

            KategoriViewModel model = new KategoriViewModel();
            //data.AktifMi = model.AktifMi;
            //data.Aciklama = model.Aciklama;
            //data.Id = model.Id.Value;

            model.Id = data.Id;
            model.AktifMi= data.AktifMi;
            model.Aciklama= data.Aciklama;

            return View(model);
        }


        [HttpPost]
        public IActionResult KategoriGuncelle(KategoriViewModel model)
        {
            KategorilerDto kategori = new KategorilerDto();
            kategori.Id = model.Id.Value;
            kategori.AktifMi = model.AktifMi;
            kategori.Aciklama = model.Aciklama;
            _kategoriApiRequest.UpdateKategori(kategori);
            return RedirectToAction("Index");
        }
    }
}
