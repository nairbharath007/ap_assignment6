using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace TryParseExample
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            
            //string input = null;
            
            // Using int.Parse
            try
            {
                int result1 = int.Parse(input);
                Console.WriteLine("Using int.Parse: " + result1);
            }
            catch (FormatException e)
            {
                //Console.WriteLine("Using int.Parse: The input string could not be parsed as an integer.");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("-------------------------------------");
            // Using int.TryParse
            int result2;
            if (int.TryParse(input, out result2))
            {
                Console.WriteLine("Using int.TryParse: " + result2);
            }
            else
            {
                Console.WriteLine("Using int.TryParse: The input string could not be parsed as an integer.");
            }
            Console.WriteLine("-------------------------------------");

            // Using Convert.ToInt32
            int result3 = Convert.ToInt32(input);
            Console.WriteLine("Using Convert.ToInt32: "+ result3);
            //Thread.Sleep(3000);
        }
    }
}

