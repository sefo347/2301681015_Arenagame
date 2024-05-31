using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Weapon
    {
        public string Name { get; private set; }
        public int AttackBonus { get; private set; }
        public int SpecialChance { get; private set; }

        public Weapon(string name, int attackBonus, int specialChance)
        {
            Name = name;
            AttackBonus = attackBonus;
            SpecialChance = specialChance;
        }

        public virtual int UseSpecialAbility(int baseAttack)
        {
            if (Random.Shared.Next(100) < SpecialChance)
            {
                // Default special ability can be defined here
                return baseAttack * 2; // For example, double attack
            }
            return baseAttack;
        }
    }
}
