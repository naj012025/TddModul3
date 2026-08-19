using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TddApi.Dto;
using TddApi.Services;
namespace TddApi.Controllers
{
    [ApiController]
    //I had a error here in routing earlier learn it needs to be correct in the () or it will fail to show or cause a compiler error.
    [Route("api/player")]
    public class PlayerController : ControllerBase
    {
        private readonly PlayerService _playerService;
        //primary constructor That the IDE gives reduces Boilerplate code will change to use this in the future 
        //but this will give the same result good to know in the future looking at old code.
        public PlayerController(PlayerService playerService)
        {
            _playerService = playerService;
        }
        //had a error her because i forgot "gain-xp" in the same line as the attribute ().
        [Authorize]
        [HttpPost("gain-xp")]
        public async Task<ActionResult<PlayerResponse>> GainXp(GainXpRequest request)
        {
            // <=0; Means less than or equal 0 keeping this so i dont forgett. 
            if (request.Amount <= 0)
                return BadRequest("Xp amount needs to be more than 0");

            var player = _playerService.GainXp(request.Amount);

            return Ok(new PlayerResponse
            {
                Level = player.Level,
                Xp = player.Xp
            });
        }


        [HttpGet]
        public ActionResult<PlayerResponse> GetPlayer()
        {
            var player = _playerService.GetPlayer();
            //Had a error I had a Big K instead of small k and Ok so i it redline Also original wrote ok with small letters
            //keeping this so i remember big O and small k in Ok;
            return Ok(new PlayerResponse
            {
                Level = player.Level,
                Xp = player.Xp
            });
        }


    }

}
