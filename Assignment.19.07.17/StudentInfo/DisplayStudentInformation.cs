using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    class DisplayStudentInformation
    {
        public void Display(string sName,int sRoolNo,int sAge, string sClass,string sUniversity)
        {
            Console.WriteLine("\nStudent's name is : " + sName);
            Console.WriteLine("Student's Rool Number : " + sRoolNo);
            Console.WriteLine("Student's Age is : " + sRoolNo);
            Console.WriteLine("Student is in {0} class " , sClass);
            Console.WriteLine("Student's University is " + sUniversity);
        }
    }
}
