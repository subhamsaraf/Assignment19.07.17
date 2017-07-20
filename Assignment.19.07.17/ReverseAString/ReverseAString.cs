using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class ReverseAString
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter a string that you want to Reverse ");
                char[] input = Console.ReadLine().ToCharArray();
                char[] output = new char[input.Length];
                string outputS = "";
                Console.WriteLine("\nReversed String is");
                for (int i = 0, j = input.Length - 1; i < input.Length && j >= 0; i++, j--)
                {
                    output[i] = input[j];
                    outputS += output[i];
                }
                Console.WriteLine("\n"+outputS + "\n");
            }
        }
    }
}
