using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfNumber
{
    class PowerOfNumber
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number, power;
                Console.WriteLine("\nEnter the Number of which you want to Find the Power");
                bool isNumber = Int32.TryParse(Console.ReadLine(), out number);
                Console.WriteLine("Enter the Power of the number");
                bool isPower = Int32.TryParse(Console.ReadLine(), out power);
                if (isNumber && isPower)
                {
                    double answer = Math.Pow(number, power);
                    Console.WriteLine("Answer is ");
                    Console.WriteLine(answer);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
    }
}
