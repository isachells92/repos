using System;
using System.Xml;

namespace Hej_världen
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Skriv ett tal som går att dela i 4: ");
                num = int.Parse(Console.ReadLine());

                if (num % 4 == 0)
                {
                    Console.WriteLine("du skrev " + num + " som går att dela i 4");
                }
                else
                {
                    Console.WriteLine("Du skrev " + num + " som inte går att dela i 4");
                }
            } while (num != num %4);
            


        }
    }
}
