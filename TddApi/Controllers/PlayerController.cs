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
        public ActionResult<PlayerResponse> GainXp(GainXpRequest request)
        {
            // <=0; betyr less than eller er lik 0 
            if (request.Amount <= 0)
                return BadRequest("Xp amount needs to be more than 0");

            var player = _playerService.GainXp(request.Amount);
            //antar i return ok in this case etter playerresponse må jeg alltid ha
            // enten () eller {} etc inne i Parantes new playerresponece ellers red line.
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
            //Husk Liten o etter O i Ok eller får du error.
            return Ok(new PlayerResponse
            {
                Level = player.Level,
                Xp = player.Xp
            });
        }


    }

}
