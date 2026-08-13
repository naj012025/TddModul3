using TddApi.Data;
using TddApi.Dto;
using XpTdd.Models;

namespace TddApi.Services
{
    public class GoblinService
    {
        //magic numbrs are xp, health.
        //private readonly Goblin _goblin = new(25, 100);
        private readonly AppDbContext _dbContext;
        //public GoblinResponse? GetGoblin(int id)
        //{
        //    if (_goblin.Id != id)
        //    {
        //        return null;
        //    }

        //    return new GoblinResponse
        //    {
        //        Id = _goblin.Id, // potential error.
        //        Health = _goblin.Health,
        //        XpReward = _goblin.XpReward,
        //        IsDead = _goblin.Isdead
        //    };
        //}

        public GoblinService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GoblinResponse> CreateGoblinAsync(
                CreateGoblinRequest request)
        {
            Goblin goblin = new(
                request.XpReward,
                request.Health);

            _dbContext.Goblins.Add(goblin);
            //SaveChangesasync insert info into the Database.
            await _dbContext.SaveChangesAsync();

            return new GoblinResponse
            {
                Id = goblin.Id,
                XpReward = goblin.XpReward,
                Health = goblin.Health,
                IsDead = goblin.Isdead

            };

        }


    }
}
