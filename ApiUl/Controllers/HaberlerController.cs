using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;

namespace ApiUl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HaberlerController : ControllerBase
    {
        private readonly IHaberService _haberService;
        public HaberlerController(IHaberService haberService) 
        {
            _haberService = haberService;
        }

        [HttpGet]
        [Route("GetAllHAber/")]
        public List<HaberlerDto> GetAllHaber() => _haberService.GetHaberler();

        [HttpGet]
        [Route("GetHaberById")]
        public HaberlerDto GetHaberById(int haberId) => _haberService.GetHaberById(haberId);

        [HttpGet]
        [Route("DeleteHaber")]
        public bool DeleteHaber(int haberId) => _haberService.DeleteHaber(haberId);


        [HttpPost]
        [Route("InsertHaber")]
        public HaberlerDto InsertHaber(HaberlerDto model) => _haberService.InsertHaber(model);

        [HttpPost]
        [Route("UpdateHaber")]
        public HaberlerDto UpdateHaber(HaberlerDto model) => _haberService.UpdateHaber(model);
    }
}

//List<HaberlerDto> GetHaberler();

//HaberlerDto GetHaberById(int id);
//HaberlerDto InsertHaber(HaberlerDto model);

//HaberlerDto UpdateHaber(HaberlerDto model);

//bool DeleteHaber(int id);
