using ApiAccess.Absract;
using Shared.Dtos;
using Shared.Helpers.Abstract;

namespace ApiAccess.Base
{
    public class YazarApiRequest : IYazarApiRequest
    {
        private readonly IRequestService _requestService;

        public YazarApiRequest(IRequestService requestService)
        {
            _requestService = requestService;
        }

        public bool DeleteYazarlar(int yazarId)
        {
            return _requestService.Get<bool>("Yazar/DeleteYazar?yazarId=" + yazarId);
        }

        public YazarlarDto GetYazarByEmailPassword(string email, string password)
        {
            return _requestService.Get<YazarlarDto>("Yazar/GetYazarByEmailPassword?email=" + email + "&password=" + password);
        }

        public YazarlarDto GetYazarById(int yazarId)
        {
            return _requestService.Get<YazarlarDto>("Yazar/GetYazarById?yazarId="+ yazarId);
        }

        public List<YazarlarDto> GetYazarlar()
        {
            return _requestService.Get<List<YazarlarDto>>("Yazar/GetAllYazarlar");
        }

        public YazarlarDto InsertYazar(YazarlarDto model)
        {
            return _requestService.Post<YazarlarDto>("Yazar/InsertYazar", model);
        }

        public YazarlarDto UpdateYazar(YazarlarDto model)
        {
            return _requestService.Post<YazarlarDto>("Yazar/UpdateYazar", model);
        }
    }
}
