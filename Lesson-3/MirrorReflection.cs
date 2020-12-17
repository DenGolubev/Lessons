using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class MirrorReflection
    {
        private string Variable { get; set; }
        public void inputReflection()
        {
            Console.WriteLine("Введите слово и нажмите Enter:");
            Variable = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Вы ввели слово - {0}", Variable);
            Console.ReadKey();
            variableReflection();
        }

        public void variableReflection() 
        {
            char[] Reflection = Variable.ToCharArray();
            Array.Reverse(Reflection);
            Variable = string.Concat(Reflection);
            Console.WriteLine("А теперь это слово наоборот - {0}", Variable);
            Console.ReadKey();
        }
    }
}
