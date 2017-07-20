using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArgument
{
    class CooandLineArgument
    {
        static void Main(string[] args)
        {
            while (true)
            {
                if (args.Length == 2)
                {
                    double length, breadth, area, perimeter;
                    bool isLength = double.TryParse(args[0], out length);
                    bool isBreadth = double.TryParse(args[1], out breadth);
                    if (isLength && isBreadth)
                    {
                        area = length * breadth;
                        perimeter = 2 * (length + breadth);
                        Console.WriteLine("Area of the Rectangle is {0} and it's perimeter is {1}", area, perimeter);
                    }               
                }
                else
                {
                    Console.WriteLine("Enter a valid Input");
                }
            }

        }
    }
}
