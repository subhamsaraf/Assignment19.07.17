using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nEnter the Number\n");
                uint n = 0;
                bool isInt = UInt32.TryParse(Console.ReadLine(), out n);
                if (isInt)
                {
                    IsCheck(n);
                }
                else
                {
                    Console.WriteLine("\n \t \t Invalid input \n \t \t Please Input a valid number \n \n");
                }
            }
        }
       static void IsCheck(uint number)
        {
            if(number == 0)
            {
                Console.WriteLine("Neither even nor odd");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("\n \t \t {0} is Even Number \n", number);
            }
            else
            {
                Console.WriteLine("\n \t \t {0} is odd number \n", number);
            }
        }
    }
}
