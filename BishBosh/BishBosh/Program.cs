using System;

namespace BishBosh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Bish-Bosh!! Ange ett nummer: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange ett till nummer [BISH!]: ");
            int bish = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange ett till nummer [Bosh!] ");
            int bosh = int.Parse(Console.ReadLine());

            if (input % bish == 0 )
            {
                Console.WriteLine("Bitch!");
            }
            else if (input % bosh == 0 )
            {
                Console.WriteLine("bosh!");
            }
            else if (input % bish == 0 && input % bosh == 0 )
            {
                Console.WriteLine("BishBOsh!!!");
            }
            else
            {
                Console.WriteLine("No bitch, no bosh. =( ");
            }

            



        }
    }
}
