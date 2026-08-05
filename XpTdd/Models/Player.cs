
using System;
using System.Collections.Generic;
using System.Text;
using TddApi;


namespace XpTdd.Models
{
    public class Player
    {
        public string? Name { get; set; }
        public int Level { get; private set; } = 1;
        public int Xp { get; private set; }
        public int Health { get; private set; }

        public bool Isdead => Health <= 0;

        public Weapon? EquipedWeapon { get; private set; }



        public void GainXp(int amount)
        {
            Xp += amount;

            while (Xp >= 100)
            {
                Xp -= 100;
                Level++;
            }
        }

        public void EquipWeapon(Weapon weapon)
        {
            EquipedWeapon = weapon;
        }

        public void Attack(Goblin goblin)
        {
            goblin.TakeDamage(EquipedWeapon!.Damage);
        }
    }
}
