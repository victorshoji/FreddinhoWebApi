using FreddinhoWebApi.Models.Mocks;
using Microsoft.AspNetCore.Mvc;

namespace FreddinhoWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PictureController : ControllerBase
    {
        [HttpGet(Name = "GetPictureId")]
        public int Get()
        {
            return FillDataModels.GetRandomId();
        }

        [HttpGet("{id:int}", Name = "GetRangePictureById")]
        public PictureMapRange Get([FromHeader] int id)
        {
            return FillDataModels.GetPictureMap(id);
        }
    }
}