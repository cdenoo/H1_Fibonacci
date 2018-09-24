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
            Console.WriteLine(Fibonacci(5));
        }

        // Returns the fibonacci number on a given position
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
    }
}
