using System;

namespace AssignmentInheritance
{
    public class Book
    {
        public int AmountOfPages { get; set; }
        public string Name { get; set; }
        public string  Author { get; set; }

        public Book()
        {

        }

       
        public virtual void ReadBlurb()
        {

            Console.WriteLine("The blurp describes a common and bland story");
        }
        public void GetBasicSpecs()
        {
            Console.WriteLine($"Amount of pages: {AmountOfPages}\n" +
                 $"Book name: {Name}\n" +
                 $"Book author: {Author}\n");
        }



    }
}