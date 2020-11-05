using System.Collections.Generic;

namespace Lektion_13
{

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> intList = new List<Person>()
            {
               new Person(){Name = "Håkan", Age = 58},
               new Person(){Name = "Andersson", Age = 85},
               new Person(){Name = "Jansson", Age = 35},
               new Person(){Name = "Petterson", Age = 35},
            };



            //        intList.Sort(MyComparison);

            //        foreach (int i in intList)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //    static int MyComparison(int i, int j)
            //    {
            //        if (i < j)
            //            return -1;
            //        else if (i > j)

            //            return 1;
            //        else
            //            return 0;
            //    //}
        }
    }
}