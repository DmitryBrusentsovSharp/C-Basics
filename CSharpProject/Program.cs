using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpProject
{
    class Program
    {
        delegate void Message();
        delegate int Math(int x, int y);

        public static void MainMethod(string[] args)
        {
            Message msg;

            if (DateTime.Now.Hour < 12) 
            {
                msg = goodMorning;                
            }
            else
            {
                msg = goodDay;
            }

            msg();

            Math operation = Add;
            Console.WriteLine(operation(5, 7));

            operation = Mult;
            Console.WriteLine(operation(5, 7));

            Console.ReadKey();
        }

        private static int Mult(int x, int y)
        {
            return x* y;
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static void goodMorning()
        {
            Console.WriteLine("Good morning");
        }

        private static void goodDay()
        {
            Console.WriteLine("Hello");
        }
    }
}
