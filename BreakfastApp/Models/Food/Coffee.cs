namespace BreakfastApp.Models.Food
{
    public static class Coffee
    {
        public static void Make()
        {            
            BoilWater();
            Brew();
            Pour();
            Console.WriteLine("~~~~");
        }

        public static void BoilWater()
        {
            Console.WriteLine("Boiling water in kettle");
            int length = 1500;
            Thread.Sleep(length);
        }

        public static void Brew()
        {
            Console.WriteLine("Brewing coffee using filters");
            int length = 1500;
            Thread.Sleep(length);
        }

        public static void Pour()
        {
            Console.WriteLine("Pouring coffee to cup");
            int length = 500;
            Thread.Sleep(length);
        }
    }
}
