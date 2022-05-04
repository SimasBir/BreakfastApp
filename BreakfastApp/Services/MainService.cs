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
        public async Task ExecuteAsync()
        {
            Console.WriteLine("Good morning, let's get ready for breakfast");
            int eggAmount = await InputHelper.GetAmountAsync("eggs");
            int baconAmount = await InputHelper.GetAmountAsync("bacon slices");
            Console.WriteLine("~~~~~~");
            double lenght = 0;

            if (eggAmount + baconAmount > 0)
            {
                lenght += await Stove.HeatUpAsync();
                lenght += await Egg.MakeAsync(eggAmount);
                lenght += await Bacon.MakeAsync(baconAmount);
            }
            lenght += await Coffee.MakeAsync();
            lenght += await Toast.MakeAsync();

            Console.WriteLine("Breakfast is ready!");
            Console.WriteLine($"Making breakfast took {lenght/1000} seconds");
        }
    }
}
