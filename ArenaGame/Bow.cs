using ArenaGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bow : Weapon
{
    public Bow() : base("Bow", 15, 20) { }

    public override int UseSpecialAbility(int baseAttack)
    {
        if (Random.Shared.Next(100) < SpecialChance)
        {
            return baseAttack * 3; // Triple damage
        }
        return baseAttack;
    }
}