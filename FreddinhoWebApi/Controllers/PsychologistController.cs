using FreddinhoWebApi.Models.Entity;
using FreddinhoWebApi.Models.Mocks;
using Microsoft.AspNetCore.Mvc;

namespace FreddinhoWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PsychologistController : ControllerBase
    {
        [HttpGet(Name = "GetPsychologistGroup")]
        public IList<PsychologistModel> Get()
        {
            return FillDataModels.CreatePsychologistGroup();
        }
    }
}