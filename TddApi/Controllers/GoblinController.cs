using Microsoft.AspNetCore.Mvc;
using TddApi.Dto;
using TddApi.Services;
namespace TddApi.Controllers
{
    [ApiController]
    [Route("api/Goblin")]
    public class GoblinController : ControllerBase
    {
        private readonly GoblinService _goblinService;
        //må ha samme navn som class.
        public GoblinController(GoblinService goblinService)
        {
            _goblinService = goblinService;
        }

        [HttpGet]
        public ActionResult<GoblinResponse> GetGoblin()
        {
            GoblinResponse goblin = _goblinService.GetGoblin();

            return Ok(goblin);
        }

        //[HttpPost("Give-Xp")]
        //public ActionResult<GoblinRequest>
    }

}
