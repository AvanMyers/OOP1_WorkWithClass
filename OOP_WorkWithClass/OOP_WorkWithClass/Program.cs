using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_WorkWithClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(100,20,10);

            player.PrintInfo();
            Console.ReadKey();
        }
    }

    class Player
    {
        public int Health;
        public int Damage;
        public int Armor;

        public Player(int health, int damage, int armot)
        {
            Health = health;
            Damage = damage;
            Armor = armot;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Здоровье - {Health}, Урон - {Damage}, Броня - {Armor}");
        }
    }
}
