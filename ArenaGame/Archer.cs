using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Archer : Hero
    {
        private const int DodgeChance = 15;

        public Archer(string name) : base(name)
        {
            Strength = 90;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(DodgeChance)) incomingDamage = 0; // Dodge the attack
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int attack = base.Attack();
            return attack + (attack * 10 / 100); // 10% extra damage
        }
    }
}
