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
    public class YazarManager : IYazarService
    {
        private readonly IRepository<Yazarlar> _yazarlarRepository;

        public YazarManager(IRepository<Yazarlar> yazarlarRepository)
        {
            _yazarlarRepository = yazarlarRepository;
        }

        public YazarlarDto GetYazarById(int id)
        {
            var responseCevp = _yazarlarRepository.GetByID(id);

            YazarlarDto result = YazarItem(responseCevp);

            return result;

        }

        public List<YazarlarDto> GetYazarlar()
        {
            var response = _yazarlarRepository.GetAll().ToList();
            List<YazarlarDto> result = new List<YazarlarDto>();

            foreach (var item in response)
            {
                result.Add(YazarItem(item));
            }

            return result;
        }

        public YazarlarDto InsertYazar(YazarlarDto model)
        {
            Yazarlar response = _yazarlarRepository.Insert(YazarItem(model));
            YazarlarDto result = YazarItem(response);
            return result;
        }

        public YazarlarDto UpdateYazar(YazarlarDto model)
        {
            Yazarlar response = _yazarlarRepository.Update(YazarItem(model));
            YazarlarDto result = YazarItem(response);
            return result;
        }

        public bool DeleteYazarlar(int id)
        {
            return _yazarlarRepository.Delete(new Yazarlar { ID = id });
        }

        private YazarlarDto YazarItem(Yazarlar model)
        {
            YazarlarDto result = new YazarlarDto();

            result.ID = model.ID;
            result.Name = model.Name;
            result.Surname = model.Surname;
            result.Email = model.Email;
            result.Password = model.Password;
            result.Resim = model.Resim;
            result.AktifMi = model.AktifMi;

            return result;
        }

        private Yazarlar YazarItem(YazarlarDto model)
        {
            Yazarlar result = new Yazarlar();

            result.ID = model.ID;
            result.Name = model.Name;
            result.Surname = model.Surname;
            result.Email = model.Email;
            result.Password = model.Password;
            result.Resim = model.Resim;
            result.AktifMi = model.AktifMi;

            return result;
        }
    }
}