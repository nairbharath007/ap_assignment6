using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsWriteLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum1 = AddNumbers(1, 2, 3);
            Console.WriteLine("Sum 1: " + sum1);

            int sum2 = AddNumbers(10, 20, 30, 40, 50);
            Console.WriteLine("Sum 2: " + sum2);

            int sum3 = AddNumbers(100);
            Console.WriteLine("Sum 3: " + sum3);

            int[] moreNumbers = { 6, 7, 8, 9, 10 };
            int sum4 = AddNumbers(moreNumbers);
            Console.WriteLine("Sum 4: " + sum4);
        }
        public static int AddNumbers(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

    }
}
//WriteLine() does not have a params[] argument, since it is already an overloaded method for 
//different datatypes and argument combinations.
//Compiler automatically chooses overload based on arguments you have provided.

