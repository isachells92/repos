using System;

namespace Deligate03
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Tilldela variabeln foo av typen Func<string, int>
            * metoden ReturnStringLength. */
            Func<string, int> foo = ReturnStringLength;

            Console.Write("Mata in en sträng: ");
            string s = Console.ReadLine();

            // Anropa metoden som variabeln foo tilldelats.
            int i = foo(s);

            Console.WriteLine($"Strängens längd = {i}");
        }

        static int ReturnStringLength(string s)
        {
            return s.Length;
        }

    }
}

