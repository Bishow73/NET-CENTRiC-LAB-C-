using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_1
{
    internal class person
    {
        int numberofEyes;
        public int noofEyes { get { return numberofEyes; } set { numberofEyes = value; } }
        public string hairColor { get; set; }
        public void EatingHabit()
        {
            Console.WriteLine("I usally have tea in break");
        }
        public void EatingHabit(string mylunch)
        {
            Console.WriteLine("i usually have" + mylunch + "in lunch");
                }
        public string EatingHabits(string mylunch)
        {
            return "I usually have" + mylunch + "in my lunch";
        }
    }
}
