using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FighterApp.Interfaces;


namespace FighterApp.Classes
{
    public class RockstarFighter : Fighter, IStreet, IBox, IMuayThai
    {
        private double Reputation { get; set; }
        public RockstarFighter(double health, double powerPunch, double speed, double reputation) : base(health, powerPunch, speed)
        {
            Reputation = reputation;
        }
        public void DoBoxing(Fighter opponent)
        {
            Console.WriteLine("Poww");
            TakeDamage((PowerPunch + Speed) * Reputation);
        }

        public void DoMuayThai(Fighter opponent)
        {
            Console.WriteLine("Uauaaa");
            TakeDamage((PowerPunch + Speed) * Reputation);
        }

        public void DoStreet(Fighter opponent)
        {
            Console.WriteLine("Splash,swashh");
            TakeDamage((PowerPunch + Speed) * Reputation);
        }

        protected override void Finisher(Fighter opponent)
        {
            if (IsDizzy())
            {
                Console.WriteLine("Rockastar Fighter will be recoveried after 10 days");
                TakeDamage();
            }
        }
    }
}
