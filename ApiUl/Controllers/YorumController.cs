using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;

namespace ApiUl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YorumController : ControllerBase
    {
        private readonly IYorumService _yorumService;
        public YorumController(IYorumService yorumService)
        {
            _yorumService = yorumService;
        }

        [HttpGet]
        [Route("GetSlaytAll")]
        public List<YorumlarDto> GetSlaytAll() => _yorumService.GetYorumlar();

        [HttpGet]
        [Route("GetYorumById")]
        public YorumlarDto GetYorumById(int slaytId) => _yorumService.GetYorumById(slaytId);

        [HttpGet]
        [Route("DeleteYorum")]
        public bool DeleteSlayt(int yazarId) => _yorumService.DeleteYorum(yazarId);

        [HttpPost]
        [Route("InsertSlayt")]
        public YorumlarDto InsertSlayt(YorumlarDto model) => _yorumService.InsertYorum(model);

        [HttpPost]
        [Route("UpdateSlayt")]
        public YorumlarDto UpdatUpdateSlayteYazar(YorumlarDto model) => _yorumService.UpdateYorum(model);
    }
}

//List<YorumlarDto> GetYorumlar();

//YorumlarDto GetYorumById(int id);

//YorumlarDto InsertYorum(YorumlarDto model);

//YorumlarDto UpdateYorum(YorumlarDto model);

//bool DeleteYorum(int id);