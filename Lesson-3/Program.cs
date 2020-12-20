using System;

namespace Lesson_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //StartMenu startMenu = new StartMenu();
            //startMenu.MyStartMenu();
            SeaBattle battle = new SeaBattle();
            battle.Coordinates();
            Console.ReadKey();
        }
        
    }
}
