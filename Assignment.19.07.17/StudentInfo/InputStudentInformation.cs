using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    class InputStudentInformation
    {
        public void Input()
        {
            DisplayStudentInformation display = new DisplayStudentInformation();
            int roolNumber,age;
            Console.WriteLine("Enter the Students Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Roll Number");
            bool isRool = Int32.TryParse(Console.ReadLine(), out roolNumber);
            Console.WriteLine("Enter the Age : ");
            bool isAge = Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Enter the Class in Which Student is : ");
            string sclass = Console.ReadLine();
            Console.WriteLine("Enter the University Name: ");
            string university = Console.ReadLine();

            if(isAge && isRool)
            {
                display.Display(name,roolNumber,age,sclass,university);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
