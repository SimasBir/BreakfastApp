using BreakfastApp.Helpers;
using BreakfastApp.Models.Food;
using BreakfastApp.Models.Appliances;

namespace BreakfastApp.Services
{
    public class MainService
    {
        public void Execute()
        {
            Console.WriteLine("Good morning, let's get ready for breakfast");
            int eggAmount = InputHelper.GetAmount("eggs");
            int baconAmount = InputHelper.GetAmount("bacon slices");
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("~~~~~~");

            if (eggAmount + baconAmount > 0)
            {
                Stove.HeatUp();
                Egg.Make(eggAmount);
                Bacon.Make(baconAmount);
            }
            Coffee.Make();
            Toast.Make();

            Console.WriteLine("Breakfast is ready!");
            stopwatch.Stop();

            Console.WriteLine($"Making breakfast took {Math.Round(stopwatch.Elapsed.TotalSeconds,2)} seconds");
        }
    }
}
