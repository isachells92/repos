using System;

namespace EnumCodeALong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Week.Onsdag); // Ger Onsdag
            Console.WriteLine((int)Week.Onsdag); // Ger 2

            Console.WriteLine($"Sunday: {Week.Torsdag} är veckans {(int)Week.Torsdag + 1}:a dag");

            Console.WriteLine();
            Console.WriteLine("Veckans alla dagar:");

            foreach (string w in Enum.GetNames(typeof(Week)))
            {
                Console.WriteLine(w);
            }
            Console.WriteLine();
            Console.WriteLine(Enum.GetName(typeof(Week), 4)); // Ger fredag
        }
        enum Week
        {
            Måndag,
            // Måndag = 1, // Startar index från 1
            Tisdag,
            Onsdag,
            Torsdag,
            Fredag,
            Lördag,
            Söndag
        }
    }
}
