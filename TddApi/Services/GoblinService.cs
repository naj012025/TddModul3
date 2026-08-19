using TddApi.Data;
using TddApi.Dto;
using XpTdd.Models;

namespace TddApi.Services
{
    public class GoblinService
    {
        //magic numbers are xp, health. in the future i want have less magic numbers because i would forget what they are.
        //private readonly Goblin _goblin = new(25, 100);
        private readonly AppDbContext _dbContext;

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
