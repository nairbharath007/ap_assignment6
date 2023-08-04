using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BoxingAndUnboxing1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList mixedList = new ArrayList();
            //List<object> mixedList = new List<object>();

            // Adding different data types to the ArrayList (boxing occurs)
            mixedList.Add(42);          // Adding an integer (boxing)
            mixedList.Add("Hello");     // Adding a string (boxing)
            mixedList.Add(3.14);        // Adding a double (boxing)

            // Displaying the elements of the ArrayList
            Console.WriteLine("Mixed List:");
            foreach (object item in mixedList)
            {
                Console.WriteLine("Type: " + item.GetType() + ", Value: " + item);
            }

            // Unboxing and using the elements from the ArrayList
            int intValue = (int)mixedList[0];    // Unboxing the integer
            string stringValue = (string)mixedList[1]; // Unboxing the string
            double doubleValue = (double)mixedList[2]; // Unboxing the double

            Console.WriteLine("\nUnboxed Values:");
            Console.WriteLine("Integer Value: " + intValue);
            Console.WriteLine("String Value: " + stringValue);
            Console.WriteLine("Double Value: " + doubleValue);
            Thread.Sleep(3000)
        }
    }
}
