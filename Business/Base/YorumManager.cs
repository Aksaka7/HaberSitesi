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
    public class YorumManager : IYorumService
    {
        private readonly IRepository<Yorumlar> _yorumRepository;

        public YorumManager(IRepository<Yorumlar> yorumRepository)
        {
            _yorumRepository = yorumRepository;
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
            List<YorumlarDto> result = new List<YorumlarDto>();

            foreach (var item in response)
            {
                result.Add(YorumItem(item));
            }

            return result;
        }

        public YorumlarDto InsertYorum(YorumlarDto model)
        {
            Yorumlar response = _yorumRepository.Insert(YorumItem(model));
            YorumlarDto result = YorumItem(response);
            return result;
        }

        public YorumlarDto UpdateYorum(YorumlarDto model)
        {
            Yorumlar response = _yorumRepository.Update(YorumItem(model));
            YorumlarDto result = YorumItem(response);
            return result;
        }

        public bool DeleteYorum(int id)
        {
            return _yorumRepository.Delete(new Yorumlar { Id = id});
        }

        private Yorumlar YorumItem(YorumlarDto model)
        {
            Yorumlar result = new Yorumlar();

            result.Id = model.Id;
            result.Name = model.Name;
            result.Surname = model.Surname;
            result.Email = model.Email;
            result.HaberID = model.HaberID;
            result.Icerik = model.Icerik;
            result.EklemeTarihi = model.EklemeTarihi;
            result.AktifMi = model.AktifMi;

            return result;
        }

        private YorumlarDto YorumItem(Yorumlar model)
        {
            YorumlarDto result = new YorumlarDto();

            result.Id = model.Id;
            result.Name = model.Name;
            result.Surname = model.Surname;
            result.Email = model.Email;
            result.HaberID = model.HaberID;
            result.Icerik = model.Icerik;
            result.EklemeTarihi = model.EklemeTarihi;
            result.AktifMi = model.AktifMi;

            return result;
        }
    }
}
