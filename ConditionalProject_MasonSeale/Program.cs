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
        static int enemyhealth = 200;
        static int CurrentWeapon = 0;
        static string[] Weapon = {"fist", "dartgun", "pistol", "shotgun", "railgun",};
        static int[] damage = { 10, 15, 20, 30, 1000 };
        static int[] currentammo = {0, 5, 4, 3, 1 };

        static void Main(string[] args)
        {
            while (true)
            {
                hud();
                playerchoice();
                if (enemyhealth <= 0)
                {
                    break;
                }
                hud();
                takeDamage(1);
                if (Health <= 0)
                {
                    break;
                }
            }
        }
        static void takeDamage(int amount)
        {
            if (enemyhealth > 0)
            {
                Console.WriteLine($"THE ENEMY ATTACKS, Took {amount} damage");
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
        }
        static void changeweapon()
        {
            CurrentWeapon += 1;
            if (CurrentWeapon >= 5)
            {
                CurrentWeapon = 4;
                Console.WriteLine("You didnt find anything");
                return;
            }
            Console.WriteLine($"you searched and found a {Weapon[CurrentWeapon]}");

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
        static void attack()
        {
            if (Health > 0)
            {
               
                Console.WriteLine("YOU ATACKED");
                enemyhealth -= damage[CurrentWeapon];
                
                if (enemyhealth <= 0)
                {
                    Console.WriteLine("YOU WIN");
                    
                }
                pew();
            }
        }
        static void pew()
        {
            if (CurrentWeapon == 0)
            {
                return;
            }
            else
            {
                currentammo[CurrentWeapon] -= 1;
                
                {                
                    if (currentammo[CurrentWeapon] <= 0)
                    {
                        CurrentWeapon -= 1;
                        
                    }

                }

            }
        }
        static void playerchoice()
        {
            while(true)
            {
                Console.WriteLine("Your move (A to attack, H to heal, F to search for stuff)");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.A)
                {
                    Console.Clear();
                    attack();
                    return;
                }
                else if (key.Key == ConsoleKey.H)
                {
                    Console.Clear();
                    heal(20);
                    return;
                }
                else if (key.Key == ConsoleKey.F)
                {
                    Console.Clear();
                    changeweapon();
                    return;
                }
                else
                {
                    Console.WriteLine("Invaled");
                }
            }
        }
        static void ammo()
        {
           if (CurrentWeapon == 0)
            {
                Console.WriteLine("current ammo: Infanite");
            }
            else
            {
                Console.WriteLine($"Current ammo: {currentammo[CurrentWeapon]}");
            }
        }

        static void hud()
        {
            Console.WriteLine($"health: {Health}     Weapon: {Weapon[CurrentWeapon]}");
            ammo();
            Console.ReadKey();
            Console.Clear();
        }

    } 
}
