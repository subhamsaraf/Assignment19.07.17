using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingAdress
{
    class Input
    {
       public void InputFunction()
        {
            Display display = new Display();
            int pinCode;
            Console.WriteLine("Enter the Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the City :");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the Pin Code :");
            bool isPin = Int32.TryParse(Console.ReadLine(), out pinCode);
            Console.WriteLine("Enter the City Street Adress :");
            string street = Console.ReadLine();
            Console.WriteLine("Enter the house No :");
            string houseNo = Console.ReadLine();
            if(isPin)
            {
                display.display(name, city, street, pinCode, houseNo);
                Console.ReadKey();

            }
        }
    }
}
