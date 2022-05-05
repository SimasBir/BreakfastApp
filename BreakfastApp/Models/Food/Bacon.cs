namespace BreakfastApp.Models.Food
{
    public static class Bacon
    {
        public static void Make(int amount)
        {
            if (amount == 0)
            {
                return;
            }

            Cut(amount);
            Cook(amount);
            Serve(amount);
            Console.WriteLine("~~~~");
        }

        private static void Cut(int amount)
        {
            Console.WriteLine($"Cutting {(amount == 1 ? amount + " slice" : amount + " slices")} of bacon");
            int length = 500 * amount;
            Thread.Sleep(length);
        }

        private static void Cook(int amount)
        {
            Console.WriteLine($"Cooking the bacon");
            int length = 1000;
            Thread.Sleep(length);
        }

        private static void Serve(int amount)
        {
            Console.WriteLine($"Serving the bacon to plate");
            int length = 500;
            Thread.Sleep(length);
        }
    }
}
