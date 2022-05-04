namespace BreakfastApp.Models.Food
{
    public static class Egg
    {
        public static int Make(int amount)
        {
            if (amount == 0)
            {
                return 0;
            }

            int lenght = 0;
            lenght += Crack(amount);
            lenght += Cook(amount);
            lenght += Serve(amount);
            Console.WriteLine("~~~~");

            return lenght;
        }

        private static int Crack(int amount)
        {
            Console.WriteLine($"Cracking {(amount == 1 ? amount + " egg" : amount + " eggs")} in to the pan");
            int length = 200 * amount;
            Thread.Sleep(length);
            return length;
        }

        private static int Cook(int amount)
        {
            Console.WriteLine($"Cooking the {(amount == 1 ? "egg" : "eggs")}");
            int length = 2000;
            Thread.Sleep(length);
            return length;
        }

        private static int Serve(int amount)
        {
            Console.WriteLine($"Serving the {(amount == 1 ? "egg" : "eggs")} to plate");
            int length = 500;
            Thread.Sleep(length);
            return length;
        }
    }
}
