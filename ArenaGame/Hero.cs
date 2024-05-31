namespace ArenaGame
{
    public class Hero
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Strength { get; protected set; }
        public bool IsDead { get { return Health <= 0; } }
        public Weapon Weapon { get; set; } // Добавяме оръжие към героя

        protected int StartingHealth { get; private set; }

        public Hero(string name)
        {
            Name = name;
            Health = 500;
            StartingHealth = Health;
            Strength = 100;
            Weapon = null; // По подразбиране героят няма оръжие
        }

        public virtual int Attack()
        {
            int attack = (Strength * Random.Shared.Next(80, 121)) / 100;
            if (Weapon != null) // Проверяваме дали героят има оръжие
            {
                attack += Weapon.AttackBonus; // Добавяме бонуса на оръжието към атаката
            }
            return attack;
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            if (incomingDamage < 0) return;
            Health -= incomingDamage;
        }

        protected bool ThrowDice(int chance)
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }

        public void ChangeWeapon(Weapon newWeapon)
        {
            Weapon = newWeapon;
        }

        protected void Heal(int value)
        {
            Health += value;
            if (Health > StartingHealth) Health = StartingHealth;
        }
    }
}
