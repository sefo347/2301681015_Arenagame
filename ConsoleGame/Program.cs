using ArenaGame;
using System;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of battles: ");
            int rounds = Int32.Parse(Console.ReadLine());
            int oneWins = 0, twoWins = 0;

            for (int i = 0; i < rounds; i++)
            {
                // Създаваме герои без оръжия
                Hero one = new Knight("Sir Lancelot");
                Hero two = new Rogue("Robin Hood");

                // Играчите избират оръжия
                Console.WriteLine($"Player One, choose weapon: (1) Sword, (2) Bow, (3) Axe");
                int weaponChoiceOne = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"Player Two, choose weapon: (1) Sword, (2) Bow, (3) Axe");
                int weaponChoiceTwo = Int32.Parse(Console.ReadLine());

                // Присвояваме избраното оръжие на героите
                one.ChangeWeapon(CreateWeapon(weaponChoiceOne));
                two.ChangeWeapon(CreateWeapon(weaponChoiceTwo));

                Console.WriteLine($"Arena fight between: {one.Name} and {two.Name}");
                Arena arena = new Arena(one, two);
                Hero winner = arena.Battle();
                Console.WriteLine($"Winner is: {winner.Name}");
                if (winner == one) oneWins++; else twoWins++;
            }
            Console.WriteLine();
            Console.WriteLine($"One has {oneWins} wins.");
            Console.WriteLine($"Two has {twoWins} wins.");

            Console.ReadLine();
        }

        // Метод за създаване на оръжие според избора на играча
        static Weapon CreateWeapon(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new Sword();
                case 2:
                    return new Bow();
                case 3:
                    return new Axe();
                default:
                    throw new ArgumentException("Invalid choice.");
            }
        }
    }
}
