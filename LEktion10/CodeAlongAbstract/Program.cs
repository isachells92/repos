using System;

namespace CodeAlongAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();    // funkar inte att använda new Animal(); men new Cat(); funkar, pga abstract class & arv.
            cat.Eat();
            Console.WriteLine(cat.Age);
        }
    }

    abstract class Animal  // Kan bara bli använd gneom arv. Om man inte behöver skapa en instans av classen Animal, dekora med abstract.
    {
        public int Age { get; set; }

        abstract public void Eat();   // en abstract metod kan inte göra någonting, blir kompileringsfel av en anledning.
        
        
    }

    class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Chewing fish and prawns. ");
        }
    }
}
