using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input4Numbers
{
    class Input4Numbers
    {
        static void Main(string[] args)
        {
            MathemeticalOperation operation = new MathemeticalOperation();
            double addition, subtraction, multipliction; 
            double first = 0, second, third, forth;
            Console.WriteLine("Enter the 1st number");
            bool isFirst = double.TryParse(Console.ReadLine(), out first);
            Console.WriteLine("Enter the 2nd number");
            bool issecond = double.TryParse(Console.ReadLine(), out second);
            Console.WriteLine("Enter the 3rd Number");
            bool isthird = double.TryParse(Console.ReadLine(), out third);
            Console.WriteLine("Enter the 4th Number");
            bool isforth = double.TryParse(Console.ReadLine(), out forth);


            if(isFirst && issecond && isthird && isforth) //To check for Valid Input
            {
                addition =operation.Addition(first, second, third, forth);
                subtraction = operation.Subtraction(first, second, third, forth);
                multipliction = operation.Multiplication(first, second, third, forth);

                Console.WriteLine("Addition of 4 numbers  = {0}", addition);
                Console.WriteLine("Subtration of 4 numbers = {0}", subtraction);
                Console.WriteLine("Multiplication of 4 Numbers = {0}", multipliction);


            }
            else
            {
                Console.WriteLine("Invalid Input: Enter a number");
            }
            Console.ReadKey();
        }
    }
    

}
