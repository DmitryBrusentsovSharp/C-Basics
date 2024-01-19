using System;
using System.Threading;

namespace CSharpProject
{
    public class Multithreading
    {
        static int count;
        static object locker = new object();
        static void Main1(string[] args)
        {     
            for (int i = 0; i < 7; i++) 
            {
                Thread myTr = new Thread(new ThreadStart(printSome));
                myTr.Name = "Potok " + i.ToString();
                myTr.Start();
            }

            Console.ReadKey();
        }

        private static void printSome()
        {
            lock (locker)
            {
                count = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {count}");
                    count++;
                    Thread.Sleep(100);
                }
            }
        }
    }
}
