using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;

namespace ApiUl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlaytController : ControllerBase
    {
        private readonly ISlaytServices _slaytService;
        public SlaytController(ISlaytServices slaytService)
        {
            _slaytService = slaytService;
        }

        [HttpGet]
        [Route("GetSlaytAll")]
        public List<SlaytlarDto> GetSlaytAll() => _slaytService.GetSlaytlar();

        [HttpGet]
        [Route("SlaytGetById")]
        public SlaytlarDto SlaytGetById(int slaytId) => _slaytService.GetSlaytById(slaytId);

        [HttpGet]
        [Route("DeleteSlayt")]
        public bool DeleteSlayt(int yazarId) => _slaytService.DeleteSlaytlar(yazarId);

        [HttpPost]
        [Route("InsertSlayt")]
        public SlaytlarDto InsertSlayt(SlaytlarDto model) => _slaytService.InsertSlayt(model);

        [HttpPost]
        [Route("UpdateSlayt")]
        public SlaytlarDto UpdatUpdateSlayteYazar(SlaytlarDto model) => _slaytService.UpdateSlayt(model);
    }
}
