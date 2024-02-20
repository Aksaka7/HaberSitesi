using Business.Abstract;
using DataAccess.Absract.Repository;
using Shared.Dtos;
using Shared.Entities;

namespace Business.Base
{
    public class YazarManager : IYazarService
    {
        private readonly IRepository<Yazarlar> _yazarlarRepository;

        public YazarManager(IRepository<Yazarlar> yazarlarRepository)
        {
            _yazarlarRepository = yazarlarRepository;
        }

        public YazarlarDto GetYazarByEmailPassword(string email, string password)
        {
            var data = _yazarlarRepository.GetAll();
            var findedData = data.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
            if (findedData != null)
                return YazarItem(findedData);
            else
                return null;

        }

        public YazarlarDto GetYazarById(int id)
        {
            var responseCevp = _yazarlarRepository.GetByID(id);

            return YazarItem(responseCevp);
        }

        public List<YazarlarDto> GetYazarlar()
        {
            var response = _yazarlarRepository.GetAll().ToList();
            List<YazarlarDto> result = new List<YazarlarDto>();

            foreach (var item in response)
                result.Add(YazarItem(item));
            
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
            YazarlarDto result = new()
            {
                ID = model.ID,
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                Password = model.Password,
                Resim = model.Resim,
                AktifMi = model.AktifMi
            };

            return result;
        }

        private Yazarlar YazarItem(YazarlarDto model)
        {
            Yazarlar result = new()
            {
                ID = model.ID,
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                Password = model.Password,
                Resim = model.Resim,
                AktifMi = model.AktifMi
            };

            return result;
        }


    }
}