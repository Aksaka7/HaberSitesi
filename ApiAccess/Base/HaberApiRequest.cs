using ApiAccess.Absract;
using Shared.Dtos;
using Shared.Entities;
using Shared.Helpers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public HaberlerDto GetHaberById(int id)
        {
            throw new NotImplementedException();
        }

        public HaberlerDto InsertHaber(HaberlerDto model)
        {
            throw new NotImplementedException();
        }

        public HaberlerDto UpdateHaber(HaberlerDto model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteHaber(int id)
        {
            throw new NotImplementedException();
        }
    }
}
