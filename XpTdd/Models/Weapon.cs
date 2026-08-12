using System;
using System.Collections.Generic;
using System.Text;

namespace XpTdd.Models
{
    public class Weapon
    {
        public int Id { get; private set; }
        public string? Name { get; set; }
        public int Damage { get; set; }


        public Weapon(int id, string name, int damage)
        {

            Id = id;
            Name = name;
            Damage = damage;
        }


    }
}
