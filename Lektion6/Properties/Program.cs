using System;
using System.Collections.Generic;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Vad är properties?? och Varför?
            //  Vi är måna om Data-integritet. Skydda data.'

            bool registerPerson = true;
            List<Person> people = new List<Person>();



            while (registerPerson)
            {
                Console.Write("Ange namn: ");
                string name = Console.ReadLine();

                if (name == "quit")
                    break;


                Console.Write("Ange ålder: ");
                int age = int.Parse(Console.ReadLine());

                Person person = new Person();
                person.Name = name;
                person.Age = age;

                people.Add(person);
            }

            foreach (Person p in people)
            {
                Console.WriteLine($"{p.Name} {p.Age}");
            }

        }

        class Person
        {
            private int age;
            public string Name;
            public string MinStrong { get; set; }   //automatic propertie; Vi kan sätta get och eller sätt till private vid behov. snipper propp

           

            public int Age                          // FULL PROPERTIE istället för automated propertie snipper "proppfull"
            {
                get {
                    return age; 
                    }

                set {
                    if (value >= 0 && value <= 110)  //Validering är Hela iden med properties!
                        age = value;
                    else
                        throw new Exception("Invalid age!");
            }



            //private int Age;
            // PROPERTIES GÖR SAMMA SAK.
            //    public void SetAge(int ageValue)
            //    {
            //        if (ageValue >= 0 && ageValue <= 110) //Validering
            //            Age = ageValue;
            //        else
            //            Age = 0;
            //            // Error handling!
            //    }
            //    public int GetAge()
            //    {
            //        return Age;
            //    }
            //}
        }
    }
}
