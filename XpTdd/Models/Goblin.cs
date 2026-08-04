using System;
using System.Collections.Generic;
using System.Text;

namespace XpTdd.Models
{
    public class Goblin
    {
        public int XpReward { get; set; }

        public int Health { get; set; }

        public Goblin(int xpReward, int health)
        {
            XpReward = xpReward;
            Health = health;
        }
    }
}
