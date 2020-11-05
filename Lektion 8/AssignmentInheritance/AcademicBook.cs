using System;

namespace AssignmentInheritance
{
    public class AcademicBook : Book
    {
        public string Subject { get; set; }
        public int Intricacy { get; set; }


        public AcademicBook(int amountOfPages, string name, string author, string subject, int intricacy)
        {
            AmountOfPages = amountOfPages;
            Name = name;
            Author = author;
            Subject = subject;
            Intricacy = intricacy;
        }

        public override void ReadBlurb()
        {
           Console.WriteLine($"The blurp describes that {Author} wrote a {AmountOfPages} long book about"  +
               $" {Subject}, called {Name} with an intricacy rating of: {Intricacy} ");
        }

    }
}