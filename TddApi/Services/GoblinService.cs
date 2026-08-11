using XpTdd.Models;
using TddApi.Dto;

namespace TddApi.Services
{
    public class GoblinService
    {
        //magic numbrs are xp, health.
        private readonly Goblin _goblin = new(25,100);

        public GoblinResponse GetGoblin()
        {
            return new GoblinResponse
            {
                Health = _goblin.Health,
                XpReward = _goblin.XpReward,
                IsDead = _goblin.Isdead
            };
        }

        
    }
}
