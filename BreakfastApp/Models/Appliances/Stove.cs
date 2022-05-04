namespace BreakfastApp.Models.Appliances
{
    public static class Stove
    {
        public static async Task<int> HeatUpAsync()
        {
            Console.WriteLine("Heating up oil in a pan");
            int length = 2000;
            Thread.Sleep(length);
            return length;
        }
    }
}
