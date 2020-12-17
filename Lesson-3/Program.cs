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
            TwoDimensionalArray twoArray = new TwoDimensionalArray();
            twoArray.OutputElements();
            PhoneDirectory phoneDirectory = new PhoneDirectory();
            phoneDirectory.MyMenu();
        }
    }
}
