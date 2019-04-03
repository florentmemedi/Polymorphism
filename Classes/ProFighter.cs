using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FighterApp.Interfaces;


namespace FighterApp.Classes
{
    public class ProFighter : Fighter, IStreet, IBox
    {
        private double Experience { get; set; }
        public ProFighter(double health, double powerPunch, double speed, double experience) : base(health, powerPunch, speed)
        {
            Experience = experience;
        }
        public void DoBoxing(Fighter opponent)
        {
            Console.WriteLine("Bam,bam,smash");
            TakeDamage((Speed + PowerPunch) * Experience);
        }

        public void DoStreet(Fighter opponent)
        {
            Console.WriteLine("Puf,paf,bong");
            TakeDamage((Speed + PowerPunch) * Experience);
        }

        protected override void Finisher(Fighter opponent)
        {
            if (IsDizzy())
            {
                Console.WriteLine("Pro Fighter will be recoveried after 15 days");
                TakeDamage();
            }
        }
    }
}
