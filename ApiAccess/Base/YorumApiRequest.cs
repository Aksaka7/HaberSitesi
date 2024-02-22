using ApiAccess.Absract;
using Shared.Dtos;
using Shared.Helpers.Abstract;

namespace ApiAccess.Base
{
    public class YorumApiRequest : IYorumApiRequest
    {
        private readonly IRequestService _requestService;
        public YorumApiRequest(IRequestService requestService)
        {
            _requestService = requestService;
        }

        public bool DeleteYorum(int yorumId)
        {
            return _requestService.Get<bool>("Yorum/DeleteYorum?yorumId=" + yorumId);
        }

        public YorumlarDto GetYorumById(int yorumId)
        {
            return _requestService.Get<YorumlarDto>("Yorum/GetYorumById?yorumId=" + yorumId);
        }

        public List<YorumlarDto> GetYorumlar()
        {
            return _requestService.Get<List<YorumlarDto>>("Yorum/GetSlaytAll");
        }

        public YorumlarDto InsertYorum(YorumlarDto model)
        {
            return _requestService.Post<YorumlarDto>("Yorum/InsertSlayt", model);
        }

        public YorumlarDto UpdateYorum(YorumlarDto model)
        {
            return _requestService.Post<YorumlarDto>("Yorum/UpdateSlayt", model);
        }
    }
}
