using XpTdd.Models;

namespace TddApi.Services
{
    public class PlayerService
    {
        //_player Underscore on private standard Convention
        private readonly Player _player = new();

        public Player GetPlayer()
        {
            return _player;
        }

        public Player GainXp(int amount)
        {
            _player.GainXp(amount);
            return _player;
        }

    }
}
