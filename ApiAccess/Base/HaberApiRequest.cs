using ApiAccess.Absract;
using Shared.Dtos;
using Shared.Helpers.Abstract;

namespace ApiAccess.Base
{
    public class HaberApiRequest : IHaberApiRequest
    {
        private readonly IRequestService _requestService;

        public HaberApiRequest(IRequestService requestService)
        {
            _requestService = requestService;
        }

        public List<HaberlerDto> GetHaberler() => _requestService.Get<List<HaberlerDto>>("Haberler/GetAllHaber");

        public HaberlerDto GetHaberById(int haberId) => _requestService.Get<HaberlerDto>("Haberler/GetHaberById?haberId=" + haberId);


        public HaberlerDto InsertHaber(HaberlerDto model) => _requestService.Post<HaberlerDto>("Haberler/InsertHaber", model);


        public HaberlerDto UpdateHaber(HaberlerDto model) => _requestService.Post<HaberlerDto>("Haberler/UpdateHaber", model);

        public bool DeleteHaber(int haberId) => _requestService.Get<bool>("/Haberler/DeleteHaber?haberId=" + haberId);
    }
}
