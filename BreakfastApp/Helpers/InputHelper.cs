namespace BreakfastApp.Helpers
{
    public static class InputHelper
    {
        public static async Task<int> GetAmountAsync(string item)
        {
            int amount = 0;
            while (item != null)
            {
                Console.WriteLine($"How many {item} would you like?");
                string input = Console.ReadLine();

                try
                {
                    amount = Convert.ToInt32(input);

                    if (amount >= 0)
                    {
                        return amount;
                    }

                    Console.WriteLine("Please enter a non-negative number");
                }
                catch
                {
                    Console.WriteLine("Please enter a number");
                }
            }
            return amount;
        }
    }
}
