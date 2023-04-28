using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace factorial
{
    class facto_reader
    {
        static void Main(string[] args)
        {
            int i, fact;
            Console.WriteLine("enter the number: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input please enter integer");
                return;
            }
            fact = number;
            for (i = number -1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFactorial of Given Number is: {0}", fact);
            Console.ReadLine();

        }
    }
}