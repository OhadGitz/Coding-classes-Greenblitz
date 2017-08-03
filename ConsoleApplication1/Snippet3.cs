using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Snippet3
    {

        static void writeHello()
        {
            Console.WriteLine("Hello");
        }

        static void Main(string[] args)
        {
            writeHello();
            Console.WriteLine("Not Hello");
            string s = Console.ReadLine();
        }
    }
}

// Exercises
// 1 - Function that prints user input.
// 2 - Function that adds two numbers and prints the result with Convert.ToInt32.
// 3 - Function that multiplies.
// 4 - Function that devides.
// 5 - Function that substracts.