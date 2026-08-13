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

        //[HttpGet("{Id}")]
        //public ActionResult<GoblinResponse> GetGoblin(int id)
        //{
        //    GoblinResponse? goblin = _goblinService.GetGoblin(id);
        //    if (goblin is null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(goblin);
        //}


        [HttpPost]
        public async Task<ActionResult<GoblinResponse>> CreateGoblin(
            CreateGoblinRequest request)
        {
            GoblinResponse goblin =
                await _goblinService.CreateGoblinAsync(request);

            return Ok(goblin);
        }
    }

}
