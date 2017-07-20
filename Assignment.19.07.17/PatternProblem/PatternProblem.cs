using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProblem
{
    class PatternProblem
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5-i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=1; k<=i;k++)
                {
                    Console.Write(k);
                }
                for(int temp = i-1;temp>=1;temp--)
                {
                    Console.Write(temp);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
