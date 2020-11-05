using System;

namespace ReadKeyTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
           ConsoleKeyInfo consoleKey = Console.ReadKey();
           // ConsoleKey key = consoleKey.Key;
            if (consoleKey.Key == ConsoleKey.A)   // Switcher på Case(ConsoleKey.A ConsoleKey S Consolekey W ConsolekEY D)
            {
                Console.WriteLine("Du tryckte på tangent A");
            }

            switch (consoleKey.Key)
            {
                case ConsoleKey.W:
                    break;
                case ConsoleKey.A:
                    break;
                case ConsoleKey.S:
                    break;
                case ConsoleKey.D:
                default:
                    Console.WriteLine("");
                    break;
              
            }


        }
    }
}
