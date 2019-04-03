using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FighterApp.Interfaces;

namespace FighterApp.Classes
{
    public class StreetFighter : Fighter, IStreet
    {
        private double StreetCredit { get; set; }
        public StreetFighter(double health, double powerPunch, double speed, double streetCredit) : base(health, powerPunch, speed)
        {
            StreetCredit = streetCredit;
        }

        public void DoStreet(Fighter opponent)
        {
            Console.WriteLine("Puang,bang,splash");
            TakeDamage((PowerPunch + Speed) * StreetCredit);

        }


        protected override void Finisher(Fighter opponent)
        {
            if (IsDizzy())
            {
                Console.WriteLine("Street Fighter will be recovered after 20 days");
                TakeDamage();
            }

        }
    }
}
