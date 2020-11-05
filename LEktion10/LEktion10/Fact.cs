using System.Buffers.Text;

namespace LEktion10
{
    class Fact : Book
    {
        public string Subject;
        public Fact(int pages, string author, int price, string subject) : base(pages, author, price) // constructor tilldelas basen.
        {                                                                                             // istället för Pages=pages, AUthor=author, etc...
            Subject = subject;
        }

    }
}
