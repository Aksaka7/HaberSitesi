using Business.Abstract;
using DataAccess.Absract.Repository;
using Shared.Dtos;
using Shared.Entities;

namespace Business.Base
{
    public class YorumManager : IYorumService
    {
        private readonly IRepository<Yorumlar> _yorumRepository;
        private readonly IRepository<Haberler> _haberRepository;

        public YorumManager(IRepository<Yorumlar> yorumRepository, IRepository<Haberler> haberRepository)
        {
            _yorumRepository = yorumRepository;
            _haberRepository = haberRepository;
        }

        public YorumlarDto GetYorumById(int id)
        {
            var responseCevp = _yorumRepository.GetByID(id);

            YorumlarDto result = YorumItem(responseCevp);

            return result;
        }

        public List<YorumlarDto> GetYorumlar()
        {
            var response = _yorumRepository.GetAll().ToList();
            List<YorumlarDto> result = [];

            foreach (var item in response)
            {
                result.Add(YorumItem(item));
            }

            return result;
        }

        public YorumlarDto InsertYorum(YorumlarDto model)
        {
            model.EklemeTarihi = DateTime.Now;
            Yorumlar response = _yorumRepository.Insert(YorumItem(model));
            return YorumItem(response);

        }

        public YorumlarDto UpdateYorum(YorumlarDto model)
        {
            var yorum = _yorumRepository.GetByID(model.Id); //Guncelleme işlemlerinde Herzaman setleme yapılması gerekir.
            yorum.Id = model.Id;
            yorum.Name = model.Name;
            yorum.Surname = model.Surname;
            yorum.Email = model.Email;
            yorum.HaberId = model.HaberId;
            yorum.Baslik = model.Baslik;
            yorum.Icerik = model.Icerik;
            yorum.AktifMi = model.AktifMi;
            Yorumlar response = _yorumRepository.Update(yorum);
            return YorumItem(response);             
        }

        public bool DeleteYorum(int id)
        {
            return _yorumRepository.Delete(new Yorumlar { Id = id });
        }

        private static Yorumlar YorumItem(YorumlarDto model)
        {
            Yorumlar result = new()
            {
                Id = model.Id,
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                HaberId = model.HaberId,
                Baslik = model.Baslik,
                Icerik = model.Icerik,
                EklemeTarihi = model.EklemeTarihi,
                AktifMi = model.AktifMi
            };

            return result;
        }

        private YorumlarDto YorumItem(Yorumlar model)
        {
            YorumlarDto result = new()
            {
                Id = model.Id,
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                HaberId = model.HaberId,
                Baslik = model.Baslik,
                Icerik = model.Icerik,
                EklemeTarihi = model.EklemeTarihi,
                AktifMi = model.AktifMi,
                HaberBaslik = _haberRepository.GetByID(model.HaberId).Baslik
            };

            return result;
        }
    }
}
