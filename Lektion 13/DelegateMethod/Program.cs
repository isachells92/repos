using System;
using System.Net.Cache;

namespace DelegateMethod
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Action<Person> OnBirthday { get; set; }
        public Action OnHellaDay { get; set; }
        public void Yearincrease()
        {
            Age++;
            OnBirthday(this);   //Använder this för att delegera användaren av klassen. !!Very important!!
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person();
            me.Age = 58;
            me.Name = "Håkan";
            me.OnBirthday = Celebrate;
            me.OnBirthday = GetMoney;
            me.OnBirthday += YearofBirth;
            me.Yearincrease();

            Person you = new Person();
            you.Age = 59;
            you.Name = "Micke";
            you.OnBirthday = Celebrate;
            you.Yearincrease();
            me.Yearincrease();
            

            Console.WriteLine($"{me.Name}{me.Age}");
            me.Yearincrease();
            Console.WriteLine($"{me.Name}{me.Age}");
        }

        private static void GetMoney(Person p)
        {
            Console.WriteLine("Goddamn! 20 000 00 Cashes! gz");
        }

        private static void Celebrate(Person p)
        {
            if (p.Age % 10 == 0)
                Console.WriteLine($"Grattis {p.Name} du fyller jämna år, det vill säga {p.Age} år");
            else
            Console.WriteLine("Yippie! HappyBirthDay");
        }
        private static void YearofBirth(Person p)
        {
            Console.WriteLine($"{p.Name} är född år {DateTime.Now.Year - p.Age}");
        }
    }
}
