using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lesson_6
{
    class Program
    {
        static Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
        static Process[] processesName = Process.GetProcesses();
        static void Main(string[] args)
        {
            GetAllProcess();
            
        }

        public static void GetAllProcess()
        {
            
            
            foreach (var item in processesName)
            {
                keyValuePairs.Add(item.Id, item.ProcessName);
                
            }
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
            Console.ReadKey();
            KillProcessByID();
        }

        private static void KillProcessByID()
        {
            try
            {
                Console.WriteLine("Введите ID номер процесс, который необходимо убить:");
                int id = int.Parse(Console.ReadLine());
                string ProcessValue = keyValuePairs[id];
                processesName = Process.GetProcessesByName(ProcessValue);
                foreach (var item in processesName)
                {
                    item.Kill();
                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
        
    }
}
