using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCar.RegNr = "KRJ1332";
            MyCar.Tillverkare = "Ford";
            MyCar.Tillverkarningsår = 2010;
            Console.WriteLine($"{MyCar.RegNr} {MyCar.Tillverkare}{MyCar.Tillverkarningsår}");

            HelenasBil.RegNr = "213J1332";
            HelenasBil.Tillverkare = "Volvo";
            HelenasBil.Tillverkarningsår = 2019;
            Console.WriteLine($"{HelenasBil.RegNr} {HelenasBil.Tillverkare}{HelenasBil.Tillverkarningsår}");

            // skapar en ny instans med nyckelordet "New".

            Car jonasCar = new Car();
            jonasCar.RegNr = "Aha 322";
            jonasCar.Tillverkare = "Aston Martin";
            jonasCar.Tillverkarningsår = 2020;

            Car kaansCar = new Car();
            kaansCar.RegNr = "TRY 656";
            kaansCar.Tillverkare = "Porche";
            kaansCar.Tillverkarningsår = 2025;


        }
    }
}
