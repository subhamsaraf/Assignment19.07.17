using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyArray
{
    class CopyArray
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the Size of the Array");
                int n;
                bool isValidSize = Int32.TryParse(Console.ReadLine(), out n);
                string[] array = new string[n];
                string[] duplicateArray = new string[n];
                if (isValidSize)
                {

                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("\nEnter the {0} element", i + 1);
                        array[i] = Console.ReadLine();
                        duplicateArray[i] = array[i];
                    }


                    Console.WriteLine("Duplicate array elements :-");

                    //Display the duplicate array
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("  "+duplicateArray[i]);
                    }
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
