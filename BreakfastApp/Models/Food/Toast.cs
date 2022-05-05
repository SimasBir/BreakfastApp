namespace BreakfastApp.Models.Food
{
    public static class Toast
    {
        public static void Make()
        {
            Toaster();
            Butter();
            Serve();
            Console.WriteLine("~~~~");
        }

        public static void Toaster()
        {
            Console.WriteLine("Toasting sliced bread in toaster");
            int length = 2000;
            Thread.Sleep(length);
        }

        public static void Butter()
        {
            Console.WriteLine("Buttering freshly toasted bread");
            int length = 1500;
            Thread.Sleep(length);
        }

        public static void Serve()
        {
            Console.WriteLine("Serving toast to plate");
            int length = 500;
            Thread.Sleep(length);
        }
    }
}
