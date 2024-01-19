using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpProject
{
    public class Numbers
    {
        private int x, y;

        public Numbers(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }
        public void printSome()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Our sobstvenny potok - " + x + " " + y);
                Thread.Sleep(300);
            }
        }
    }
}
