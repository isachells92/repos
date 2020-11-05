using System;

namespace CodeAlongeMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoText();
            Addera(3, 5);
            Console.ReadLine();
        }

        private static void Addera(int v1, int v2)
        {
            Console.WriteLine($"Summan blir {v1 + v2}. ");
        }

        private static void InfoText()
        {
            Console.WriteLine("Nu ska vi Summera 3 och 5");
            
        }
    }
}
