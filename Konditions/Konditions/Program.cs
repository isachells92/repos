using System;

namespace Konditions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.Write("Ange namn: ");
                string name = Console.ReadLine().ToLower();

                if (name == "micke" || name == "håkan")
                {
                    Console.Write("Lärare");
                }
                else if (name == " christer")
                {
                    Console.Write("Bossen");
                }
                else if (name == "quit")
                {
                    loop = false;
                    Console.Write("Avslutar... tryck på [ENTER] tangenten.");
                }
                else
                {
                    Console.Write("Elev");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
