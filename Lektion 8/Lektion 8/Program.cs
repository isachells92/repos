using System;

namespace Lektion_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ternary <----- ?? \\
            // Controll shift mellanslag! För att se parametrar.

            RunConstructorDemo();

        }
          // WOW!!!  använd Shift enter skapa en metod, HIGHLOGHTA CODEN SEN SHIFTA DEN RACKARN.
        private static void RunConstructorDemo()
        {
            Car myCar = new Car("Volvo V70", 2006);                      // If < 5 return "ny" else return "gammal";
            Console.WriteLine($"En{myCar.Model} som är {myCar.Age} år{(myCar.Age < 5 ? "ny" : "gammal")}");
        }
    }
}
