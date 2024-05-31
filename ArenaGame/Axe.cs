using ArenaGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Axe : Weapon
{
    public Axe() : base("Axe", 25, 5) { }

    public override int UseSpecialAbility(int baseAttack)
    {
        if (Random.Shared.Next(100) < SpecialChance)
        {
            return baseAttack + 100; // Adds extra 100 damage
        }
        return baseAttack;
    }
}
