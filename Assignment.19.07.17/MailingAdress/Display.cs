using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingAdress
{
    class Display
    {
        public void display(string name,string city,string street,int pin,string houseNo)
        {
            Console.WriteLine("The Nmae of the preson is " + name);
            Console.WriteLine("The city is " + city);
            Console.WriteLine("The street name is: " + street);
            Console.WriteLine("Thhe pincode is : " + pin);
            Console.WriteLine("House Number is : " + houseNo);
        }
    }
}
