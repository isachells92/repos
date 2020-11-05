using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace SwitchMethodMenuCodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            bool menu = false;
            while (running)
            {
                Meny();

            }



        }

        public static void Meny()
        {

            Console.Write("Vad vill du göra?");
            Console.WriteLine("1: ange siffraA. 2: angesiffraB, 3: Ange Namn, 4 angeSiffra3. 5 avsluta");
            string input = Console.ReadLine();
            Console.WriteLine("----------------");


            switch (input)
            {
                case "1":
                    AngeSiffra();
                    break;
                case "2":
                    AngeSiffra2();
                    break;
                case "3":
                    angeNamn();
                    break;
                case "4":
                    AngeSiffra3();
                    break;
                case "5":
                    Console.WriteLine("avslutar");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }

        private static void angeNamn()
        {
            Console.Write("Ange namn: ");
            string name = Console.ReadLine();

            switch (name.ToLower())
            {
                case "micke":
                case "håkan":
                    Console.WriteLine("Lärare");
                    break;
                case "christer":
                    Console.WriteLine("Chefen");
                    break;
                case "4":
                    AngeSiffra3();
                    break;
                default:
                    Console.WriteLine("Elev");
                    break;
            }

        }

        static void AngeSiffra3()
        {
            Console.Write("Ange siffra, Tryparse: ");
            string input = Console.ReadLine();
            int number;
            bool success = int.TryParse(input, out number);

            if (success)
            {
                Console.WriteLine($"Converted {input} to {number}");
            }
            else
            {
                Console.WriteLine($"Attempted conversion of {input}");
            }
        }  

         static void AngeSiffra2()
        {
            Console.Write("Ange siffra, switch: ");
            int caseSwitch2 = int.Parse(Console.ReadLine());

            switch (caseSwitch2)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }

         static void AngeSiffra()
        {
            Console.Write("Ange siffra, switch: ");
            int caseSwitch1 = int.Parse(Console.ReadLine());

            switch (caseSwitch1)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }


        }
    }
}
