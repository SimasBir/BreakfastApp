using BreakfastApp.Helpers;
using BreakfastApp.Models.Food;
using BreakfastApp.Models.Appliances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastApp.Services
{
    public class MainService
    {
        public void Execute()
        {
            Console.WriteLine("Good morning, let's get ready for breakfast");
            int eggAmount = InputHelper.GetAmount("eggs");
            int baconAmount = InputHelper.GetAmount("bacon slices");
            Console.WriteLine("~~~~~~");
            double lenght = 0;

            if (eggAmount + baconAmount > 0)
            {
                lenght += Stove.HeatUp();
                lenght += Egg.Make(eggAmount);
                lenght += Bacon.Make(baconAmount);
            }
            lenght += Coffee.Make();
            lenght += Toast.Make();

            Console.WriteLine("Breakfast is ready!");
            Console.WriteLine($"Making breakfast took {lenght/1000} seconds");
        }
    }
}
