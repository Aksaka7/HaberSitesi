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
        [Route("GetYorumAll")]
        public List<YorumlarDto> GetYorumAll() => _yorumService.GetYorumlar();

        [HttpGet]
        [Route("GetYorumById")]
        public YorumlarDto GetYorumById(int yorumId) => _yorumService.GetYorumById(yorumId);

        [HttpGet]
        [Route("DeleteYorum")]
        public bool DeleteYorum(int yorumId) => _yorumService.DeleteYorum(yorumId);

        [HttpPost]
        [Route("InsertYorum")]
        public YorumlarDto InsertYorum(YorumlarDto model) => _yorumService.InsertYorum(model);

        [HttpPost]
        [Route("UpdateYorum")]
        public YorumlarDto UpdateYorum(YorumlarDto model) => _yorumService.UpdateYorum(model);
    }
}

//List<YorumlarDto> GetYorumlar();

//YorumlarDto GetYorumById(int id);

//YorumlarDto InsertYorum(YorumlarDto model);

//YorumlarDto UpdateYorum(YorumlarDto model);

//bool DeleteYorum(int id);