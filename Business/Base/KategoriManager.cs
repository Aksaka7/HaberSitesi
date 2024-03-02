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

            return KategoriItem(response);
        }

        public List<KategorilerDto> GetKategorilerList()
        {
            var response = _kategorilerRepository.GetAll().ToList();
            List<KategorilerDto> result = [];

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

        private static Kategoriler KategoriItem(KategorilerDto model)
        {
            Kategoriler result = new()
            {
                Id = model.Id,
                AktifMi = model.AktifMi,
                Aciklama = model.Aciklama
            };

            return result;
        }

        private static KategorilerDto KategoriItem(Kategoriler model)
        {
            KategorilerDto result = new()
            {
                Id = model.Id,
                AktifMi = model.AktifMi,
                Aciklama = model.Aciklama
            };

            return result;
        }
    }
}
