using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Sword : Weapon
    {
        public Sword() : base("Sword", 20, 10) { }

        public override int UseSpecialAbility(int baseAttack)
        {
            if (Random.Shared.Next(100) < SpecialChance)
            {
                return baseAttack + 50; // Adds extra 50 damage
            }
            return baseAttack;
        }

    }
}