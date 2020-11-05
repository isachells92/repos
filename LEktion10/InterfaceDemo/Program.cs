using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");        // interfaces ligger i en egen fil, i ett namespace - som klasser.!! -normalt sätt. !!

            IActivity activity = new Dog();          //Här är ett bra syntax exempel på klasser o interfaces!
            activity.MainActivity();                // för att använda en interface, skapar man en klass som kan använda den. !! -That's it. !!
                                                    // Classer som är inte relaterade via arv, kan ändå använda använda samma Metod.!! -Interface Magic. !!
            IActivity carActivity = new Car();
            carActivity.MainActivity();


            List<int> wholeNumbers = new List<int>() { 58, 14, 44, 10 };

            IntComparer comparer = new IntComparer();                // här använder vi ett interfaces med namnet IntComparer när vi anropar sort();
            wholeNumbers.Sort(comparer);                             // Det är alltså Sort som anropar IntComparer.
                                                                     // kan ändra metoden Compare för att ändra hur Sort funkar.
                                                                     // !!!! Kanske använda Class Person IComparer<> I Tjuv och Polis !!!!
                                                                     // Skapa en Lista med Person och props firstname lastname age som i exemplet här.!! Och använd ICOMPARE för att justera listan!!

            foreach (int number in wholeNumbers)
            {
                Console.Write($"{number}");
            }
            List<Car> cars = new List<Car>()              // Object initsialiser code.
            {
                new Car() {TopSpeed = 110},
                new Car() {TopSpeed = 90},
                new Car() {TopSpeed = 80 }
            };
            Car car1 = new Car();                               // Car har ingen base comparer så vi skapar en via interfaces.
            cars.Sort(car1);
            /*cars.Sort(cars[0]);    */                   // Behöver en instans av listan, vilken som helst,
            foreach (Car  car in cars)                    // Sort anropar alltså en metod som heter Compare, och i det här fallet våran Compare.
            {
                Console.WriteLine(car.TopSpeed);          // Här ser vi implimenteringen av car. 
            }

        }
    }

    class IntComparer : IComparer<int>                           // Samma kompileringsfel som IACTIVITY, använd alt och enter.
    {
        public int Compare([AllowNull] int x, [AllowNull] int y)
        {
            if (x < y)
                return -1;              //kan switcha den här med "return 1" för att ändra sorteringen från stigande, till fallande ordning.
            else if (x > y)             // Sorterings algoritmen?
                return 1;
            else
                return 0;
        }
    }

    interface IActivity                                   //finns oftast metoder här men även properties ibland,
    {
        public void MainActivity();                       // allting i en interface är public ++ Kan inte skapa instanser av interfaces.
    }

    class Dog : IActivity
    {
        public void MainActivity()
        {
            Console.WriteLine("Barking and eating all day long");
        }
    }

    class Car : IActivity, IComparer<Car>                     // Här är ett exempel på multiple interfaces.
    {
        public int TopSpeed { get; set; }

        public int Compare([AllowNull] Car x, [AllowNull] Car y)
        {
            if (x.TopSpeed > y.TopSpeed)
                return 1;
            else
                if (x.TopSpeed < y.TopSpeed)
                    return -1;
                else
                    return 0;
        }

        public void MainActivity()
        {
            Console.WriteLine("Driving and honking the horn");
        }
    }

}
