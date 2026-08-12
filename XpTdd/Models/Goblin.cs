using System;
using System.Collections.Generic;
using System.Text;

namespace XpTdd.Models
{
    public class Goblin
    {
        public int Id { get; private set; }
        public int XpReward { get; set; }

        public int Health { get; set; }

        public bool Isdead => Health <= 0;

        public Goblin(int id, int xpReward, int health)
        {
            Id = id;
            XpReward = xpReward;
            Health = health;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
