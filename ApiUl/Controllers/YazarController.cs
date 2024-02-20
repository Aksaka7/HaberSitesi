using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;

namespace ApiUl.Controllers
{
    public class YazarController : Controller
    {
        private readonly IYazarService _yazarService;
        public YazarController(IYazarService yazarService)
        {
            _yazarService = yazarService;
        }

        [HttpGet]
        [Route("GetAllYazarlar")]
        public List<YazarlarDto> GetAllYazar() => _yazarService.GetYazarlar();

        [HttpGet]
        [Route("GetYazarByEmailPassword")]
        public YazarlarDto GetYazarByEmailPassword(string email, string password) => _yazarService.GetYazarByEmailPassword(email, password);

        [HttpGet]
        [Route("GetYazarById")]
        public YazarlarDto GetYazarlarById(int yazarId) => _yazarService.GetYazarById(yazarId);

        [HttpGet]
        [Route("DeleteYazar")]
        public bool DeleteYazar(int yazarId) => _yazarService.DeleteYazarlar(yazarId);

        [HttpPost]
        [Route("InsertYazar")]
        public YazarlarDto InsertYazar(YazarlarDto model) => _yazarService.InsertYazar(model);

        [HttpPost]
        [Route("UpdateYazar")]
        public YazarlarDto UpdateYazar(YazarlarDto model) => _yazarService.UpdateYazar(model);
    }
}
