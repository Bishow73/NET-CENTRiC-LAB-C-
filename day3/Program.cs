using System;
using day3_1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person Bishow =new person();
            Bishow.noofEyes = 2;
            Bishow.hairColor = "Black";
            Console.WriteLine("you have"+ Bishow.noofEyes+  " Eyes");
            Console.WriteLine("you have" + Bishow.hairColor + "hair");
            Bishow.EatingHabit();
            Bishow.EatingHabit("chowin");
            string mylunch = Bishow.EatingHabits("Biryani");
            Console.WriteLine(mylunch);
            Console.ReadKey();        
        }
    }
}
