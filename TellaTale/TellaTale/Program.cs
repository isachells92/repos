using System;

namespace TellaTale
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Skriv ditt namn");
            string name = Console.ReadLine();

            Console.WriteLine("Skriv din ålder");
            string age = Console.ReadLine();

            Console.WriteLine("Ange kön:");
            string gender = Console.ReadLine();


            Console.WriteLine("Skriv staden du bor i");
            string location = Console.ReadLine();

            Console.WriteLine("Skriv din favorit djur");
            string animal = Console.ReadLine();



            Console.WriteLine($"Det var en gång en trebent hamster som hette {name}.");
            Console.WriteLine($"{name} förlorade sitt ena ben i kriget och var nu på jakt efter en magisk {animal}, som {gender} hade hört att kunde läka hamstrar");
            Console.WriteLine($"{name} hade färdats igenom öknar, träsk och berg, slagits mot ekorrar och möss, och var nu äntligen framme vid {location}");
            Console.WriteLine($"igenom grottan sågs en {animal} som dansade i regnet.");
            Console.WriteLine($"Bara {gender} med den perfekta ålder får tillgång till min helande-hudsalva trademark, sa djuret");
            Console.WriteLine($"MIN ÅLDER ÄR {age} skrek {name}..... och var nu återligen en mäktig och fyrbent hamster. slut");
        }
    }
}
