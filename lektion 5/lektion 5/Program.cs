using System;
using System.ComponentModel.DataAnnotations;

namespace lektion_5
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoText();
            Addera(9, 11);
            int result = Subtrahera(25,13);
            Console.WriteLine(result);

            Console.WriteLine($"Belopp med moms: {AmountIncludingMoms(100)}");
        }

        

        private static double AmountIncludingMoms(double v)
        {
            return v + AdderaMoms(v);
        }

        private static double AdderaMoms(double v)
        {
            return v*0.25;
        }

        private static int Subtrahera(int v1, int v2)
        {
            int summa = v1 - v2;
            return summa;
        }

        private static void Addera(int v1, int v2)
        {
            Console.WriteLine(v1+v2);
        }
        private static int Addera2(int v1, int v2)
        {
            int summa = v1 + v2;
            return summa;
        }
       

        private static void InfoText()
        {
            Console.WriteLine("En text... ");
        }
    }
}
