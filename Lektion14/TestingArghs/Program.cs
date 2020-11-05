using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AnonomysTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new { FirstName = "Håkan", Age = 58, Phone = "070 464 74 31" };
            Console.WriteLine(x.Phone);

            List<Person> people = new List<Person>();

            people.Add(new Person { FirstName = "Håkan", LastName = "Johansson", BirthYear = 1962 });
            people.Add(new Person { FirstName = "Nathalie", LastName = "Johansson", BirthYear = 2006 });
            people.Add(new Person { FirstName = "Kenneth", LastName = "Johansson", BirthYear = 2009 });
            people.Add(new Person { FirstName = "Micke", LastName = "Engström", BirthYear = 1965 });
            people.Add(new Person { FirstName = "Carin", LastName = "Cula", BirthYear = 1989 });

            var q = people
                .Where(p => p.BirthYear >= 1980);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Här händer saker aaaa {i}");
            }     
                // .Select(p => new { Ålder = p.Age, CompleteName = $"{p.FirstName} {p.LastName}" });
            
            foreach (var p in q)
            {
                Console.WriteLine(p.FirstName);
            }
        }
    }
}
