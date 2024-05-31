using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Mage : Hero
    {
        private const int MagicShieldChance = 20;

        public Mage(string name) : base(name)
        {
            Strength = 80;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(MagicShieldChance)) incomingDamage /= 2; // Halve the damage
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int attack = base.Attack();
            return attack + (attack * 20 / 100); // 20% extra damage
        }
    }
}
