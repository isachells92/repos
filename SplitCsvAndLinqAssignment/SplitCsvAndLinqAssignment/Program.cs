using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SplitCsvAndLinqAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> myCsvList = new List<Person>();
            AddPersonsToList(myCsvList);

            var q1 = myCsvList
                .OrderByDescending(p => p.Name).ToList();


            foreach (var person in myCsvList)
            {
                Console.WriteLine(person.Name);
            }
        }
        private static void AddPersonsToList(List<Person> persons)
        {
            const string filePath = @"C:\Users\karre\Downloads\names.csv";
            //const string filePath = @"C:\Data\C#\Academy\2018\HT\Patriks övningar\Övning_24_LINQ\Övning_24_LINQ\names.csv";

            foreach (string person in File.ReadLines(filePath, System.Text.Encoding.UTF7))
            {
                string[] personData = person.Split(';');

                if (PersonNotInList(personData[0], persons))
                {
                    Person p = new Person
                    {
                        Name = personData[0],
                        NameDay = DateTime.Parse(personData[1])
                    };
                    persons.Add(p);

                    // OR ...

                    //persons.Add(new Person { Name = personData[0], NameDay = DateTime.Parse(personData[1]) });
                }
            }
        }

        private static bool PersonNotInList(string name, List<Person> persons)
        {
            bool nameFound = false;

            foreach (Person person in persons)
            {
                nameFound = person.Name.ToLower() == name.ToLower();

                if (nameFound)
                    break;
            }

            return !nameFound;
        }

    }
}
