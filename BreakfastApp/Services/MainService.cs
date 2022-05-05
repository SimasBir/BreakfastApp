using BreakfastApp.Helpers;
using BreakfastApp.Models.Food;
using BreakfastApp.Models.Appliances;
using System.Threading;

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

            Task thread1 = Task.Factory.StartNew(() => Cooking(eggAmount, baconAmount));
            Task thread2 = Task.Factory.StartNew(() => Coffee.Make());
            Task thread3 = Task.Factory.StartNew(() => Toast.Make());

            Task.WaitAll(thread1, thread2, thread3);
            Console.WriteLine("Breakfast is ready!");
            stopwatch.Stop();

            Console.WriteLine($"Making breakfast took {Math.Round(stopwatch.Elapsed.TotalSeconds, 2)} seconds");
        }

        private static void Cooking(int eggAmount, int baconAmount)
        {
            if (eggAmount + baconAmount > 0)
            {
                Stove.HeatUp();
                Egg.Make(eggAmount);
                Bacon.Make(baconAmount);
            }
        }
    }
}
