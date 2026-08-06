using Microsoft.AspNetCore.Mvc;
using TddApi.Dto;
using TddApi.Services;
namespace TddApi.Controllers
{
    [ApiController]
    //jeg hadde feil routing hadde /i begynnelsen.
    [Route("api/player")]
    public class PlayerController : ControllerBase
    {
        private readonly PlayerService _playerService;

        public PlayerController(PlayerService playerService)
        {
            _playerService = playerService;
        }
        //hadde glemt og legge til "gain-xp" i samme line som httppost i parantes 
        [HttpPost("gain-xp")]
        public ActionResult<PlayerResponse> GainXp(int amount)
        {
            var player = _playerService.GainXp(amount);

            return Ok(new PlayerResponse
            {
                Level = player.Level,
                Xp = player.Xp
            });
        }

    }

}
