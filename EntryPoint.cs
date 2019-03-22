using System;
using System.Threading;
using WarriorWars.Enums;

namespace WarriorWars
{
    class EntryPoint
    {
        static Random rng = new Random();
        
        static void Main()
        {
            Warrior goodGuy = new Warrior("Nate", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Voldemort", Faction.BadGuy);
            
            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }

                Thread.Sleep(500);
            }
        }
    }
}
