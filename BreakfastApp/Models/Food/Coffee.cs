namespace BreakfastApp.Models.Food
{
    public static class Coffee
    {
        public static async Task<int> MakeAsync()
        {            
            int lenght = 0;

            lenght += await BoilWater();
            lenght += await Brew();
            lenght += await Pour();
            Console.WriteLine("~~~~");

            return lenght;
        }

        public static async Task<int> BoilWater()
        {
            Console.WriteLine("Boiling water in kettle");
            int length = 1500;
            Thread.Sleep(length);
            return length;
        }

        public static async Task<int> Brew()
        {
            Console.WriteLine("Brewing coffee using filters");
            int length = 1500;
            Thread.Sleep(length);
            return length;
        }

        public static async Task<int> Pour()
        {
            Console.WriteLine("Pouring coffee to cup");
            int length = 500;
            Thread.Sleep(length);
            return length;
        }
    }
}
