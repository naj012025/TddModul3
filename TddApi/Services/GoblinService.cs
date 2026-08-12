using TddApi.Dto;
using XpTdd.Models;

namespace TddApi.Services
{
    public class GoblinService
    {
        //magic numbrs are xp, health.
        private readonly Goblin _goblin = new(999, 25, 100);

        public GoblinResponse? GetGoblin(int id)
        {
            if (_goblin.Id != id)
            {
                return null;
            }

            return new GoblinResponse
            {
                Id = _goblin.Id,
                Health = _goblin.Health,
                XpReward = _goblin.XpReward,
                IsDead = _goblin.Isdead
            };
        }


    }
}
