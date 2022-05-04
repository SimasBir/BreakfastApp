using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastApp.Models.Food
{
    public static class Toast
    {
        public static int Make()
        {
            int lenght = 0;

            lenght += Toaster();
            lenght += Butter();
            lenght += Serve();
            Console.WriteLine("~~~~");

            return lenght;
        }

        public static int Toaster()
        {
            Console.WriteLine("Toasting sliced bread in toaster");
            int length = 2000;
            Thread.Sleep(length);
            return length;
        }

        public static int Butter()
        {
            Console.WriteLine("Buttering freshly toasted bread");
            int length = 1500;
            Thread.Sleep(length);
            return length;
        }

        public static int Serve()
        {
            Console.WriteLine("Serving toast to plate");
            int length = 500;
            Thread.Sleep(length);
            return length;
        }
    }
}
