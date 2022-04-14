using FreddinhoWebApi.Models.Mocks;
using Microsoft.AspNetCore.Mvc;

namespace FreddinhoWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PsychologistController : ControllerBase
    {
        [HttpGet(Name = "GetPsychologistGroup")]
        public IList<Psychologist> Get()
        {
            return FillDataModels.CreatePsychologistGroup();
        }
    }
}