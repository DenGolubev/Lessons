using System;

namespace Lesson_2
{
    partial class MinMaxTemp
    {
        private string MinTemp { get; set; }
        private string MaxTemp { get; set; }

        private string CheckConsoleEnter(string a)
        {
            label1: // Необходимо уйти от оператора goto
            a = Console.ReadLine();
            char[] variable = a.ToCharArray();
            if (a.Length < 1)
            {
                Console.WriteLine("Вы допустили ошибку ввода, попробуйте еще раз:\n");
                goto label1; // Необходимо уйти от оператора goto
            }
            else
            {
                foreach (char c in variable)
                {
                    if (char.IsLetter(c))
                    {
                        Console.WriteLine("Вы допустили ошибку ввода, попробуйте еще раз:\n");
                        goto label1; // Необходимо уйти от оператора goto
                    }

                }
            }
            return a;
        }

        private double AverTemp(string a, string b)
        {
            return (Convert.ToDouble(a) + Convert.ToDouble(b)) / 2;
        }

    }
}
