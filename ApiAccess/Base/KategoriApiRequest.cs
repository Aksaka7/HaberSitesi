using ApiAccess.Absract;
using Shared.Dtos;
using Shared.Helpers.Abstract;

namespace ApiAccess.Base
{
    public class KategoriApiRequest : IKategoriApiRequest
    {
        private readonly IRequestService _requestService;
        public KategoriApiRequest(IRequestService requestService)
        {
            _requestService = requestService;
        }

        public List<KategorilerDto> GetKategoriler()
        {
            return _requestService.Get<List<KategorilerDto>>("/Kategori/GetAllKategori");
        }

        public KategorilerDto GetKategoriById(int kategoriId)
        {
            return _requestService.Get<KategorilerDto>("/Kategori/GetByIdKategori?kategoriId=" + kategoriId);
        }

        public KategorilerDto KategoriEkle(KategorilerDto model)
        {
            return _requestService.Post<KategorilerDto>("/Kategori/InsertKategori", model);
        }

        public KategorilerDto UpdateKategori(KategorilerDto model)
        {
            return _requestService.Post<KategorilerDto>("/Kategori/UpdateKategori", model);
        }

        public bool DeleteKategori(int kategoriId)
        {
          return  _requestService.Get<bool>("/Kategori/DeleteKategori?kategoriId=" + kategoriId);
        }

    }
}
