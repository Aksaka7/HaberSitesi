using Business.Abstract;
using DataAccess.Absract.Repository;
using Shared.Dtos;
using Shared.Entities;

namespace Business.Base
{
    public class KategoriManager : IKategoriService
    {
        private readonly IRepository<Kategoriler> _kategorilerRepository;

        public KategoriManager(IRepository<Kategoriler> kategorilerRepository)
        {
            _kategorilerRepository = kategorilerRepository;
        }

        public KategorilerDto GetKategoriById(int id)
        {
            var response = _kategorilerRepository.GetByID(id);

            KategorilerDto result = KategoriItem(response);

            return result;
        }      

        public List<KategorilerDto> GetKategorilerList()
        {
            var response = _kategorilerRepository.GetAll().ToList();
            List<KategorilerDto> result = new List<KategorilerDto>();

            foreach (var item in response)
                result.Add(KategoriItem(item));

            return result;

        }

        public KategorilerDto InsertKategori(KategorilerDto model)
        {
            Kategoriler response = _kategorilerRepository.Insert(KategoriItem(model));
            KategorilerDto result = KategoriItem(response);
            return result;
        }

        public KategorilerDto UpdateKategori(KategorilerDto model)
        {
            Kategoriler response = _kategorilerRepository.Update(KategoriItem(model));
            KategorilerDto result = KategoriItem(response);
            return result;
        }

        public bool DeleteKategori(int id)
        {
            return _kategorilerRepository.Delete(new Kategoriler() { Id = id });
        }

        private Kategoriler KategoriItem(KategorilerDto model)
        {
            Kategoriler result = new Kategoriler();

            result.Id = model.Id;
            result.AktifMi = model.AktifMi;
            result.Aciklama = model.Aciklama;

            return result;
        }

        private KategorilerDto KategoriItem(Kategoriler model)
        {
            KategorilerDto result = new KategorilerDto();

            result.Id = model.Id;
            result.AktifMi = model.AktifMi;
            result.Aciklama = model.Aciklama;

            return result;
        }
    }
}
