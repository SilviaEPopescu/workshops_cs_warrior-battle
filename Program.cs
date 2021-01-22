using System;

namespace WarriorBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FIGHT!");


            Warrior firstWarrior = new Warrior("Hercules", 100, 20, 8);
            firstWarrior.GetAttack();

        }
    }
}
