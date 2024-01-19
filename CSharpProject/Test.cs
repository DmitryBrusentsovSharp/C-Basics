using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public class Test<Type1, Type2>
    {
        public Type1 field;
        public Type2 field2;

        public Test(Type1 field, Type2 field2) 
        {
            this.field = field;
            this.field2 = field2;
            Console.WriteLine(field + " " + field2);
        }
    }
}
