using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastApp.Models.Appliances
{
    public static class Stove
    {
        public static int HeatUp()
        {
            Console.WriteLine("Heating up oil in a pan");
            int length = 2000;
            Thread.Sleep(length);
            return length;
        }
    }
}
