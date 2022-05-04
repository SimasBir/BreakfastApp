namespace BreakfastApp.Models.Food
{
    public static class Bacon
    {
        public static int Make(int amount)
        {
            if (amount == 0)
            {
                return 0;
            }

            int lenght = 0;
            lenght += Cut(amount);
            lenght += Cook(amount);
            lenght += Serve(amount);
            Console.WriteLine("~~~~");

            return lenght;
        }

        private static int Cut(int amount)
        {
            Console.WriteLine($"Cutting {(amount == 1 ? amount + " slice" : amount + " slices")} of bacon");
            int length = 500 * amount;
            Thread.Sleep(length);
            return length;
        }

        private static int Cook(int amount)
        {
            Console.WriteLine($"Cooking the bacon");
            int length = 1000;
            Thread.Sleep(length);
            return length;
        }

        private static int Serve(int amount)
        {
            Console.WriteLine($"Serving the bacon to plate");
            int length = 500;
            Thread.Sleep(length);
            return length;
        }
    }
}
