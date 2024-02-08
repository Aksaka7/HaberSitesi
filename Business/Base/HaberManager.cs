using Business.Abstract;
using DataAccess.Absract.Repository;
using Shared.Dtos;
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Base
{
    public class HaberManager : IHaberService
    {
        private readonly IRepository<Haberler> _repository;

        public HaberManager(IRepository<Haberler> repository)
        {
            _repository = repository;
        }


        public HaberlerDto GetHaberById(int id)
        {
            var responseCevap = _repository.GetByID(id);

            HaberlerDto result = HaberItem(responseCevap);
            //result.Id = responseCevap.Id;
            //result.Baslik = responseCevap.Baslik;
            //result.Icerik = responseCevap.Icerik;
            //result.AktifMi = responseCevap.AktifMi;
            //result.YazarId = responseCevap.YazarId;
            //result.EklenmeTarihi = responseCevap.EklenmeTarihi;
            //result.Resim = responseCevap.Resim;
            //result.KategoriID = responseCevap.KategoriID;
            //result.GosterimSayisi = responseCevap.GosterimSayisi;
            //result.Video = responseCevap.Video;

            return result;
            
        }

        public List<HaberlerDto> GetHaberler()
        {
            var response = _repository.GetAll().ToList();
            List<HaberlerDto> result = new List<HaberlerDto>();
            foreach (var item in response)
            {
                result.Add(HaberItem(item));
            }

            return result;
        }

        public HaberlerDto InsertHaber(HaberlerDto model)
        {
            //HaberlerDto response = HaberItem(_repository.Insert(HaberItem(model))); // TEk satırda Kod yazdık
            Haberler response = _repository.Insert(HaberItem(model));
            HaberlerDto result = HaberItem(response);            
            return result;

        }

        public HaberlerDto UpdateHaber(HaberlerDto model)
        {
            Haberler response = _repository.Update(HaberItem(model));
            HaberlerDto result = HaberItem(response);
            return result;
        }

        public bool DeleteHaber(int id)
        {
            //Haberler request = new Haberler(); // Aşagıdaki kod satırında tek satırda Kod yazdık
            //request.Id = id;
            return _repository.Delete(new Haberler { Id = id });
        }

        private HaberlerDto HaberItem(Haberler model)
        {
            HaberlerDto result = new HaberlerDto();
            result.Id = model.Id;
            result.Baslik = model.Baslik;
            result.Icerik = model.Icerik;
            result.AktifMi = model.AktifMi;
            result.YazarId = model.YazarId;
            result.EklenmeTarihi = model.EklenmeTarihi;
            result.Resim = model.Resim;
            result.KategoriID = model.KategoriID;
            result.GosterimSayisi = model.GosterimSayisi;
            result.Video = model.Video;

            return result;
        }

        private Haberler HaberItem(HaberlerDto model)
        {
            Haberler result = new Haberler();
            result.Id = model.Id;
            result.Baslik = model.Baslik;
            result.Icerik = model.Icerik;
            result.AktifMi = model.AktifMi;
            result.YazarId = model.YazarId;
            result.EklenmeTarihi = model.EklenmeTarihi;
            result.Resim = model.Resim;
            result.KategoriID = model.KategoriID;
            result.GosterimSayisi = model.GosterimSayisi;
            result.Video = model.Video;

            return result;
        }
    }
}
