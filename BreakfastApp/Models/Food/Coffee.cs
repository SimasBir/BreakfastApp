using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastApp.Models.Food
{
    public static class Coffee
    {
        public static int Make()
        {            
            int lenght = 0;

            lenght += BoilWater();
            lenght += Brew();
            lenght += Pour();
            Console.WriteLine("~~~~");

            return lenght;
        }

        public static int BoilWater()
        {
            Console.WriteLine("Boiling water in kettle");
            int length = 1500;
            Thread.Sleep(length);
            return length;
        }

        public static int Brew()
        {
            Console.WriteLine("Brewing coffee using filters");
            int length = 1500;
            Thread.Sleep(length);
            return length;
        }

        public static int Pour()
        {
            Console.WriteLine("Pouring coffee to cup");
            int length = 500;
            Thread.Sleep(length);
            return length;
        }
    }
}
