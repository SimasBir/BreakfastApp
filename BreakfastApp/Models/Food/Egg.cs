namespace BreakfastApp.Models.Food
{
    public static class Egg
    {
        public static void Make(int amount)
        {
            if (amount == 0)
            {
                return;
            }

            Crack(amount);
            Cook(amount);
            Serve(amount);
            Console.WriteLine("~~~~");
        }

        private static void Crack(int amount)
        {
            Console.WriteLine($"Cracking {(amount == 1 ? amount + " egg" : amount + " eggs")} in to the pan");
            int length = 200 * amount;
            Thread.Sleep(length);
        }

        private static void Cook(int amount)
        {
            Console.WriteLine($"Cooking the {(amount == 1 ? "egg" : "eggs")}");
            int length = 2000;
            Thread.Sleep(length);
        }

        private static void Serve(int amount)
        {
            Console.WriteLine($"Serving the {(amount == 1 ? "egg" : "eggs")} to plate");
            int length = 500;
            Thread.Sleep(length);
        }
    }
}
