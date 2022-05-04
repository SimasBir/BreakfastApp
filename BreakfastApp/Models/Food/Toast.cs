namespace BreakfastApp.Models.Food
{
    public static class Toast
    {
        public static async Task<int> MakeAsync()
        {
            int lenght = 0;

            lenght += await Toaster();
            lenght += await Butter();
            lenght += await Serve();
            Console.WriteLine("~~~~");

            return lenght;
        }

        public static async Task<int> Toaster()
        {
            Console.WriteLine("Toasting sliced bread in toaster");
            int length = 2000;
            Thread.Sleep(length);
            return length;
        }

        public static async Task<int> Butter()
        {
            Console.WriteLine("Buttering freshly toasted bread");
            int length = 1500;
            Thread.Sleep(length);
            return length;
        }

        public static async Task<int> Serve()
        {
            Console.WriteLine("Serving toast to plate");
            int length = 500;
            Thread.Sleep(length);
            return length;
        }
    }
}
