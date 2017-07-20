using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapiningVariables
{
    class SwappingVariables
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int firstNumber, secondNumber;
                Console.WriteLine("\n \nEnter 2 numbers that you wanna swap");
                Console.WriteLine("Enter First Number");
                bool isFirst = Int32.TryParse(Console.ReadLine(), out firstNumber);
                Console.WriteLine("Enter the second Number");
                bool isSecond = Int32.TryParse(Console.ReadLine(), out secondNumber);
                if (isFirst && isSecond)
                {
                    Swap(firstNumber, secondNumber);   
                }
                else
                {
                    Console.WriteLine("Enter a Valid Input \n");
                }
            }
        }
        static void Swap(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Numbers before Swapping are: ");
            Console.WriteLine("First Number = {0}\t Second Number = {0} ", firstNumber, secondNumber);


            firstNumber = firstNumber + secondNumber;  //working input(a=5 b=7)  a=12
            secondNumber = firstNumber - secondNumber;  //b=12-7 = 5
            firstNumber = firstNumber - secondNumber;   //c= 12-5


            Console.WriteLine("\nNumbers after Swapping are :");
            Console.WriteLine("First number = {0} \t Second Number = {1} ", firstNumber, secondNumber);
        }
    }
}
