using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public abstract class Human
    {
        protected virtual void sayHello() 
        {
            Console.WriteLine("Ololo");
        }

        protected abstract void talk();
    }
}
