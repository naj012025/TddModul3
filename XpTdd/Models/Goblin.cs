using System;
using System.Collections.Generic;
using System.Text;

namespace XpTdd.Models
{
    public class Goblin
    {
        //Hadde id i constructor men tok den ut av pga skal bruke sql og den tar seg av id.
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
