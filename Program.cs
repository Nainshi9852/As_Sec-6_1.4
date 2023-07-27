using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
            Console.ReadKey();
        }
        static void doApp()
        {
            // Declare variables of primitive types
            int intVar = 42;
            double doubleVar = 3.14;
            char charVar = 'A';
            bool boolVar = true;

            // Display the values of primitive variables
            Console.WriteLine("intVar: " + intVar);
            Console.WriteLine("doubleVar: " + doubleVar);
            Console.WriteLine("charVar: " + charVar);
            Console.WriteLine("boolVar: " + boolVar);

            // Perform operations using arrays
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.5, 2.7, 3.9, 4.2, 5.1 };

            // Calculate the sum of elements in the arrays
            int sumIntArray = 0;
            double sumDoubleArray = 0.0;

            foreach (int num in intArray)
            {
                sumIntArray += num;
            }

            foreach (double num in doubleArray)
            {
                sumDoubleArray += num;
            }

            // Display the sum of elements in the arrays
            Console.WriteLine("Sum of elements in intArray: " + sumIntArray);
            Console.WriteLine("Sum of elements in doubleArray: " + sumDoubleArray);

            // Expressions
            int result1 = intVar + intArray[0];
            double result2 = doubleVar * doubleArray[1];

            // Display the results of the expressions
            Console.WriteLine("intVar + intArray[0]: " + result1);
            Console.WriteLine("doubleVar * doubleArray[1]: " + result2);
        }
    }

}

