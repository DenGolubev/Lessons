using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //TwoDimensionalArray twoArray = new TwoDimensionalArray();
            PhoneDirectory phoneDirectory = new PhoneDirectory();
            //twoArray.OutputElements();
            phoneDirectory.AddUser();
        }
    }
}
