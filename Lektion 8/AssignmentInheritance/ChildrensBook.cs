using System;

namespace AssignmentInheritance
{
    public class ChildrensBook : Book
    {
        public int AgeRecommendation { get; set; }
        public bool IsPictureBook { get; set; }

        public ChildrensBook(int amountOfPages, string name, string author, int ageRecommendation, bool isPictureBook)
        {
            AmountOfPages = amountOfPages;
            Name = name;
            Author = author;
            AgeRecommendation = ageRecommendation;
            IsPictureBook = isPictureBook;
        }
        public override void ReadBlurb()
        {
            Console.WriteLine($"The blurp describes that {Author} wrote a {AmountOfPages} long book." +
          $" The claim that this book is a picture book is: {IsPictureBook}, and the age recommendation is {AgeRecommendation} ");
        }
        public ChildrensBook()
        {

        }
    }
}