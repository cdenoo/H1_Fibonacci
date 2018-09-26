using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Version 1 result: {0}\nVersion 2 result: {1}", Fibonacci(5), FibonacciV2(5));
        }

        // Returns the fibonacci number on a given position
        // (Integer) -> Integer
        private static int Fibonacci(int position)
        {
            int index = 0, previous = 0, next = 1, result = 0;
            while(index < position)
            {
                result = previous;
                previous = next;
                next += result;
                index++;
            }
            return result;
        }

        private static int FibonacciV2(int position)
        {
            int[] fibArray = FibonacciArray(1000);
            return fibArray[position-1];
        }

        // Returns an array (size numberofvalues) of fibonacci numbers
        // (Integer) -> [Integer, ...]
        private static int[] FibonacciArray(int numberofvalues)
        {
            int[] resultsArray = new int[numberofvalues];

            int index = 0, previous = 0, next = 1, fib = 0;

            while(index < numberofvalues)
            {
                fib = previous;
                previous = next;
                next += fib;

                resultsArray[index] = fib;
                index++;
            }
            return resultsArray;
        }

        private static void PrintIntegerArray(int[] integerArray)
        {
            for(int i = 0; i<integerArray.Length; i++)
            {
                Console.WriteLine(integerArray[i]);
            }
        }
    }
}
