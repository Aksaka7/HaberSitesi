using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;

namespace ApiUl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategoriController : ControllerBase
    {
        private readonly IKategoriService _kategoriService;
        public KategoriController(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }

        [HttpGet]
        [Route("GetAllKategori")]
        public List<KategorilerDto> GetAllKategori() => _kategoriService.GetKategorilerList();

        [HttpGet]
        [Route("GetByIdKategori")]
        public KategorilerDto GetByIdKategori(int id) => _kategoriService.GetKategoriById(id);

        [HttpGet]
        [Route("DeleteKategori")]
        public bool DeleteKategori(int kategoriId) => _kategoriService.DeleteKategori(kategoriId);

        [HttpPost]
        [Route("InsertKategori")]
        public KategorilerDto InsertKategori(KategorilerDto model) => _kategoriService.InsertKategori(model);

        [HttpPost]
        [Route("UpdateKategori")]
        public KategorilerDto UpdateKategori(KategorilerDto model) => _kategoriService.UpdateKategori(model);
    }
}
