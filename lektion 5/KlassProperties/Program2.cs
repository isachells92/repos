using System;
using System.Collections.Generic;
using System.Text;

namespace KlassProperties
{
    class Program2
    {
        internal static void PersonStory()
        {    // p1 är en riktig person. Person är en ritning.
            // Classes and Properties.
            Person p1 = new Person();
            p1.Name = "Nisse";
            p1.BirthYear = 1980;
            p1.HasCar = true;
            p1.Age = Person.CalculateAge(p1.BirthYear);

            Console.WriteLine(Person.BuildStory(p1));


            // Classes and Properties.
            Person p2 = new Person();
            p2.Name = "Dylan";
            p2.BirthYear = 1989;
            p2.HasCar = false;
            p2.Age = Person.CalculateAge(p2.BirthYear);

            Console.WriteLine(Person.BuildStory(p2));

        }
    }
}
