using System;
using System.Collections.Generic;
using System.Text;

namespace XpTdd.Models
{
    public class Goblin
    {
        //Had id in constructor but tok it away Beacuse the Sql will take care of it later.
        public int Id { get; private set; }
        public int XpReward { get; set; }

        public int Health { get; set; }

        public bool Isdead => Health <= 0;

        public Goblin(int xpReward, int health)
        {

            XpReward = xpReward;
            Health = health;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
