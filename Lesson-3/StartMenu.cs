using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class StartMenu
    {
        public void MyStartMenu()
        {
            Console.WriteLine("Упражнение №3\n");
            Console.WriteLine("Выберите пункт меню и нажмите Enter:\n");
            Console.WriteLine("Упражнение1 - 1\nУпражнение2 - 2\nУпражнение3 - 3\nУпражнение4 - 4\n");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    TwoDimensionalArray twoArray = new TwoDimensionalArray();
                    twoArray.OutputElements();
                    break;
                case 2:
                    PhoneDirectory phoneDirectory = new PhoneDirectory();
                    phoneDirectory.MyMenu();
                    break;
                case 3:
                    MirrorReflection reflection = new MirrorReflection();
                    reflection.inputReflection();
                    break;
                case 4:
                    SeaBattle seaBattle = new SeaBattle();
                    //seaBattle.MyMenu();
                    break;
            }
        }
    }
}
