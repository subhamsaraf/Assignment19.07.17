using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class TaxCalculator
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("\nMoney for Tax Calculation");
                double money,result;
                bool isNumber = double.TryParse(Console.ReadLine(), out money);
                if(isNumber)
                {
                    result = TaxCalculation(money);
                    Console.WriteLine("Tax to be Piad is {0}" , result);
                }
                else
                {
                    Console.WriteLine("Money Can Only be in Digits.");
                }

            }
        }
        static double TaxCalculation(double money)
        {
            double tax=0;
            if(money<10000)
            {
                tax = (money * 0.05);
            }
            else if(money>=10000 && money <= 100000)
            {
                tax = ((9999 * 0.05) + ((money - 9999) * 0.08));
            }
            else
            {
                tax = ((9999 * 0.05) + (90001 * 0.08) + ((money - 100000) * 0.085));
            }
            return tax;
        }
    }
}
