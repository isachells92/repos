using System;

namespace AssignmentInheritance
{
    public class FictionalBook : Book
    {
        public string FantasyGenre { get; set; }
        public bool IsAnthology { get; set; }

        public FictionalBook(int amountOfPages, string name, string author, string fantasyGenre, bool isAnthology)
        {
            AmountOfPages = amountOfPages;
            Name = name;
            Author = author;
            FantasyGenre = fantasyGenre;
            IsAnthology = isAnthology;
        }
        public override void ReadBlurb()
        {
            Console.WriteLine($"The blurp describes that {Author} wrote a {AmountOfPages} long book in the {FantasyGenre} genre." +
            $" The claim that this book is an anthology is: {IsAnthology}.");

        }

    }
}