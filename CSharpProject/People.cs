using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public class People : Human
    {
        protected override void talk()
        {
            Console.WriteLine("Razgovor");
        }
    }
}
