using AdminUI.Models;
using ApiAccess.Absract;
using ApiAccess.Base;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;

namespace AdminUI.Controllers
{
    public class YazarController : Controller
    {
        private readonly IYazarApiRequest _yazarApiRequest;
        private readonly ICommonApiRequest _commonApiRequest;
        public YazarController(IYazarApiRequest yazarApiRequest, ICommonApiRequest commonApiRequest)
        {
            _yazarApiRequest = yazarApiRequest;
            _commonApiRequest = commonApiRequest;
        }

        public IActionResult Index() => View(_yazarApiRequest.GetYazarlar());


        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YazarEkle(YazarViewModel model)
        {
            var resimUrl = _commonApiRequest.Upload(model.ResimFile);

            YazarlarDto yazar = new YazarlarDto();
            yazar.Name = model.Name;
            yazar.Surname = model.Surname;
            yazar.Email = model.Email;
            yazar.Password = model.Password;
            yazar.AktifMi = model.AktifMi;
            yazar.Resim = resimUrl;
            var result = _yazarApiRequest.InsertYazar(yazar);
            return RedirectToAction("Index");
        }

        public IActionResult Guncelle(int yazarId)
        {
            var yazar = _yazarApiRequest.GetYazarById(yazarId);
            YazarViewModel model = new YazarViewModel();
            model.Id = yazarId; 
            model.Name = yazar.Name;
            model.Surname = yazar.Surname;
            model.Email = yazar.Email;
            model.Password = yazar.Password;
            model.Resim = yazar.Resim;
            model.AktifMi = yazar.AktifMi;

            return View(model);
        }

        [HttpPost]
        public IActionResult YazarGuncelle(YazarViewModel model)
        {
            string resimUrl = model.Resim;
            if (model.ResimFile != null)
            {
                resimUrl = _commonApiRequest.Upload(model.ResimFile);
            }

            YazarlarDto yazarlarDto = new YazarlarDto();
            yazarlarDto.Id = model.Id;
            yazarlarDto.Name = model.Name;
            yazarlarDto.Surname = model.Surname;
            yazarlarDto.Email = model.Email;
            yazarlarDto.Password = model.Password;
            yazarlarDto.AktifMi = model.AktifMi;
            yazarlarDto.Resim = resimUrl;

            _yazarApiRequest.UpdateYazar(yazarlarDto);
            return RedirectToAction("Index", "Yazar");
        }


        public IActionResult Sil(int yazarId)
        {
            _yazarApiRequest.DeleteYazarlar(yazarId);
            return RedirectToAction("Index");
        }
    }
}
