using System;

namespace KlassProperties
{
    internal class Person
    {
        // Properties (Automatic properties)
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public int Age { get; set; }
        public bool HasCar { get; set; }
        public  static int CalculateAge(int birthYear)
        {
            int year = DateTime.Now.Year;
            return year - birthYear;
        }
        public static string BuildStory(Person p)
        {
            string story = $"Det var en gång en person som hette {p.Name}. Hen var {p.Age} år gammal.";
            if (p.HasCar)
            {
                story += "Hen hade en väldigt fin bil";     // Sträng kokantinering via variabel.
            }
            else
            {
                story += "Hen hade ingen bil. Snyft...";
            }

            return story;
        }


    }
}