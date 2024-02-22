using ApiAccess.Absract;
using Shared.Dtos;
using Shared.Helpers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAccess.Base
{
    public class SlaytApiRequest : ISlaytApiRequest
    {
        private readonly IRequestService _requestService;
        public SlaytApiRequest(IRequestService requestService)
        {
            _requestService = requestService;
        }

        public bool DeleteSlaytlar(int slaytId)
        {
            return _requestService.Get<bool>("Slayt/DeleteSlayt?slaytId=" + slaytId);
        }

        public List<SlaytlarDto> GetSlaytlar()
        {
            return _requestService.Get<List<SlaytlarDto>>("Slayt/GetSlaytAll");
        }

        public SlaytlarDto GetSlaytById(int slaytId)
        {
            return _requestService.Get<SlaytlarDto>("Slayt/SlaytGetById?slaytId=" + slaytId);
        }

        public SlaytlarDto InsertSlayt(SlaytlarDto model)
        {
            return _requestService.Post<SlaytlarDto>("Slayt/InsertSlayt", model);
        }

        public SlaytlarDto UpdateSlayt(SlaytlarDto model)
        {
            return _requestService.Post<SlaytlarDto>("Slayt/UpdateSlayt", model);
        }
    }
}
