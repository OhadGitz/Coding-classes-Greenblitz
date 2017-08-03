using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Snippet4
    {

        static int add(int number1, int number2)
        {
            Console.WriteLine("Number 1 = " + number1);
            Console.WriteLine("Number 2 = " + number2);
            return number1 + number2;
        }

        static int greater(int number1, int number2)
        {
            if(number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        static void Main(string[] args)
        {
            int int_var = add(1, 2);
            Console.WriteLine("Number 1 + Number 2 = " + int_var);
        }
    }
}

// Make a calulator