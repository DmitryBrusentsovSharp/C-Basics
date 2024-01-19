using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public class MainProgram
    {

        delegate float SquareNumber(float number);
        public static void Main1(string[] args)
        {
            SquareNumber square = x => x * x;

            List<int> numbers = new List<int>();
            numbers.AddRange(Enumerable.Range(1, 10));

            List<int> digits = new List<int>();
            digits.AddRange(Enumerable.Range(11, 20));

            List<string> words = new List<string> { "roads", "home", "country", "take", "me", "home" };
            string result = string.Join(" ", words.Distinct());
            Console.WriteLine(result);


            var groupAndMultiply = numbers.Zip(digits, (x, y) => x * y);

            foreach (var el in groupAndMultiply) 
            {
                Console.WriteLine(el);
            }

            Console.ReadKey();
        }
    }
}
