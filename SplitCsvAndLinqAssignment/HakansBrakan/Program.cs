using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HakansBrakan
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            AddPersonsTooList(persons);
            Console.WriteLine(persons.Count);

            NamesThatStartsWith("And", persons);
            NameDayAt(new DateTime(2020, 7, 23), persons);

            //NameStartsWIthNameDayinMonth();

            //MatchingNames(persons);

            //MatchingNameDay(persons);

            //NumberOFNamesForEachInitialLetter(persons);
            //QuerySyntaxNumberOFNamesForEachInitialLetter(persons);

            NumberOfNamesForEachMonth(persons);
            // NumberOfNameesForEachQuarter();   // Finns Utils klasss bibliotek och Between Metod för att hitta quartal.
            // FiveMostCommonDayNames();

        }
        private enum MonthName
        {
            januari = 1, februari, mars, april, maj, juni, juli, augusti,september, october, novermber, december
        }

        private static void NumberOfNamesForEachMonth(List<Person> persons)
        {
            var q = persons
                .GroupBy(p => p.NameDay.Month)
                .OrderBy(g => g.Key);

            foreach (var group in q)   // finns paint där vi ska implimentera dessa enums.
            {
               //  Console.WriteLine($"{group.Key.ToShortDateString()} {group.Count()}");
            }

        }

        private static void QuerySyntaxNumberOFNamesForEachInitialLetter(List<Person> persons)
        {
            var p7 =
                 from person in persons
                 orderby person.Name
                 group person by person.Name[0];

            foreach (var people in p7)
            {
                Console.WriteLine($"Key: {people.Key} Total: {people.Count()}");
            }

        }
        private static void NumberOFNamesForEachInitialLetter(List<Person> persons)
        {
            var resultSet = persons
                 .GroupBy(n => n.Name[0])             // kan använda nästlad foreach.... groupbystyle.
                 .OrderByDescending(k => k.Count())
                 .Take(3);

                                                                   //fet kod från Mikael holmgren
            foreach (IGrouping<char, Person> group in resultSet)  //nestlad foreach för kollektion peron i kollektion group
            {
                Console.WriteLine($"{group.Key} ({group.Count()})");

                foreach (var item in group)
                {
                    Console.WriteLine($"{item.Name} \t {item.NameDay.ToShortDateString()}");   // Tar bort tiden också.
                }
            }
        }

        private static void MatchingNameDay(List<Person> persons)
        {
            Console.Write("Mate in ett datum (MMDD): ");
            string input = Console.ReadLine();
            int month = int.Parse(input.Substring(0, 2));  //substring 2 parametrar, index och längd.
            int day = int.Parse(input.Substring(2, 2));

            var resultSet = persons
                .Where(p => p.NameDay.Month == month && p.NameDay.Day == day)
                .Select(p => $"{p.Name} {p.NameDay} ");

            foreach (var item in resultSet)
            {
                Console.WriteLine(item);
            }
        }

        private static void MatchingNames(List<Person> persons)
        {
            Console.Write("Mate in ett namn eller en del av ett namn: ");
            string input = Console.ReadLine();

            var resultSet = persons
                .Where(p => p.Name.ToLower().Contains(input.ToLower()))
                .Select(p => p.Name);

            foreach (var name in resultSet)
            {
                Console.WriteLine(name);
            }
        }

        //private static void NameStartsWIthNameDayinMonth(DateTime dateTime, List<Person> persons)
        //{
        //    var resultSet = person
        //        .Where(p =>)
        //}

        private static void NameDayAt(DateTime dateTime, List<Person> persons)
        {
            var resultSet = persons              // eller q1
                .Where(p => p.NameDay.Month == dateTime.Month && p.NameDay.Day == dateTime.Day)
                .Select(p => $"{p.Name}{p.NameDay}");

            // eller
            //foreach (var item in resultSet)
            //{
            //    Console.WriteLine($"{item.Name}{item.NameDay}");
            //}
        }

        private static void NamesThatStartsWith(string startsWidth, List<Person> persons)
        {
            var resultSet = persons
                .Where(p => p.Name.StartsWith(startsWidth))
                .Select(p => p.Name);

            foreach (string name in resultSet)
            {
                Console.WriteLine(name);
            }

        }

        static void AddPersonsTooList(List<Person> persons)
        {
            const string filePath = @"C:\Users\karre\Downloads\names.csv";
            int rowCount = 0;

            foreach (string person in File.ReadLines(filePath, System.Text.Encoding.UTF7))
            {
                string[] personData = person.Split(';');   // Splittar allting mellan char ' ' e.g: " ; ".

                if (PersonNotInList(personData[0], persons))    // Testa collektionen igen! (2).
                {
                    Person p = new Person();     // om personen inte finns i listan, då skapar vi han - via personData 0 1.
                    p.Name = personData[0];
                    p.NameDay = DateTime.Parse(personData[1]);
                    persons.Add(p);
                }
                rowCount++;

                //  Console.WriteLine(person);   // Testar collektionen (1) i loopen för att kontrollera struktur.
            }
            Console.WriteLine($"Totalt antal rader inklusive dubletter: {rowCount}");

        }

        private static bool PersonNotInList(string name, List<Person> persons)
        {
            bool nameFound = false;

            foreach (Person person in persons)
            {
                nameFound = person.Name.ToLower() == name.ToLower();     // Lite logic för att kolla om personen finns i listan, eller om inte då skapar vi en,

                if (nameFound)
                    break;
            }
            return !nameFound;
        }
    }
}
