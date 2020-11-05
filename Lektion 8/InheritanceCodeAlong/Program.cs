using System;
using System.Collections.Generic;

namespace InheritanceCodeAlong
{
    class Program               //FIXA INDENTERING 
    {
        static void Main(string[] args)
        {
            List<Animal> zoo = new List<Animal>();
            Owl owly = new Owl(1, true, 100);
            zoo.Add(owly);

            Dolphin dolphiny = new Dolphin(50, false, 200);
            zoo.Add(dolphiny);

            Horse horsy = new Horse(600, false, 20);
            zoo.Add(horsy);

            foreach (Animal anAnimal in zoo)
            {
                Console.WriteLine($"Weight: {anAnimal.Weight}");
                Console.WriteLine($"Nocturnal: {anAnimal.Nocturnal}");
                anAnimal.Move();
            }


        }
    }
    // Animal is our base-class.
    class Animal
    {
        public int Weight { get; set; }
        public bool Nocturnal { get; set; }
        public virtual void Move()
        {
            Console.WriteLine("Blahblahblah...");
        }
    }
    class Owl : Animal
    {
        public int Wingspan { get; set; }
        public Owl(int weight, bool isNocturnal, int wingspan)
        {
            Weight = weight;
            Nocturnal = isNocturnal;
            Wingspan = wingspan;
        }

        public override void Move()
        {
            Console.WriteLine("The owl flies around in the sky");
        }
        class Dolphin : Animal
        {
            public int FishPerDay { get; set; }
            public Dolphin(int weight, bool isNocturnal, int fishPerDay)
            {
                Weight = weight;
                Nocturnal = isNocturnal;
                FishPerDay = fishPerDay;

            }
            public override void Move()
            {
                Console.WriteLine("The dolphin swims around in the wast ocean.");
            }
            class Horse : Animal
            {
                public int HayPerDay { get; set; }
                public Horse(int weight, bool isNocturnal, int hayPerDay)
                {
                    Weight = weight;
                    Nocturnal = isNocturnal;
                    HayPerDay = hayPerDay;
                }
                public override void Move()
                {
                    Console.WriteLine("The horse walks around in the park");
                }
                public override string ToString()   /// Att overrada Tostring i min klass.
                {
                    return $"Weight: {Weight} Nocturnal: {Nocturnal}Wingpan: {Wingspan}";
                }
            }
        }
    }
}
