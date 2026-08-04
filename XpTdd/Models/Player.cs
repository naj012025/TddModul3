u
using System;
using System.Collections.Generic;
using System.Text;

namespace XpTdd.Models
{
    public class Player
    {
        public string? Name { get; set; }
        public int Level { get; private set; } = 1;
        public int Xp { get; private set; }

        public void GainXp(int Xp)
        {
            while (Xp >= 100)
            {
                Xp -= 100;
                Level++;
            }
        }
    }
}
