using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalProject_MasonSeale
{
    internal class Program
    {
        static int Health = 100;
  
        static int weapon = 0;

        static void Main(string[] args)
        {
            hud();
            takeDamage(20);
            hud();
            changeweapon(2);
            hud();
            heal(10);
            hud();
            takeDamage(50);
            hud();
        }
        static void takeDamage(int amount)
        {
            Console.WriteLine($"Took {amount} damage");
            Health -= amount;
            if (Health > 75)
            {
                Console.WriteLine("Perfectly healthy");
            }
            else if (Health > 50)
            {
                Console.WriteLine("Healthy");
            }
            else if (Health > 25)
            {
                Console.WriteLine("injured");
            }
            else if (Health > 10)
            {
                Console.WriteLine("Critical");
            }
            else if (Health <= 0)
            {
                Console.WriteLine("Game over");
            }
        }
        static void changeweapon(int swap)
        {
            weapon = swap;
        }
        static void heal(int amount)
        {
            Console.WriteLine($"healed {amount} health");
            Health += amount;
            if (Health > 75)
            {
                Console.WriteLine("Perfectly healthy");
            }
            else if (Health > 50)
            {
                Console.WriteLine("Healthy");
            }
            else if (Health > 25)
            {
                Console.WriteLine("injured");
            }
            else if (Health > 10)
            {
                Console.WriteLine("Critical");
            }
            else if (Health <= 0)
            {
                Console.WriteLine("Game over");
            }

        }
        static void hud()
        {
            Console.WriteLine($"health: {Health}     Weapon: {whatweapon()}");
            Console.ReadKey();
            Console.Clear();
        }
        static string whatweapon()
        {
            if (weapon == 0)
            {
                return "fist";
            }
            else if (weapon == 1)
            {
                return "pistol";
            }
            else if (weapon == 2)
            {
                return "Shotgun";
            }
            else
            {
                return ("invalide");
            }
        }
    }
}
