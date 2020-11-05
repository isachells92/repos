using AssignmentInheritance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace Libraryw
{

    public class Library
    {
        public string Name;
        private List<Book> books;
        public Library(string name)
        {
            Name = name;
            books = new List<Book>();
        }
        AcademicBook anAcademicBook = new AcademicBook(400, "The mother of all physics", "Sir IsacHellström", "Physics", 4);
        FictionalBook aFictionalBook = new FictionalBook(600, "Game of leggs", "George DD Marthun", "medieval/magical", true);
        public void RunMenu()
        {
            bool menu = true;
            while (menu == true)
            {
                Console.WriteLine("Library 1.0 what do you want to do? \n " +
                    "1: Add childrens Book. \n " +
                    "2: Add fictional Book \n" +
                    "3: Add academic Book \n" +
                    "4: Print basic specifics \n" +
                    "5: Print detailed specifics \n " +
                    "6: Sort Books \n" +
                    "7: Print All Books \n" +
                    "8: Exit.");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        AddChildrensBook();
                        break;
                    case 2:
                //      AddFictionalBook();
                        break;
                    case 3:
                  //    AddAcademicBook();
                        break;
                    case 4:
                        Console.WriteLine("What book do you want to inspect? ");
                        string input = Console.ReadLine();
                       GetBasicSpecs (books[0]);
                        break;
                    case 5:
                 //       GetMoreSpecs();
                        break;
                    case 6:
                        SortBooks();
                        break;
                    case 7:
                        PrintBooks();
                        break;
                    case 8:
                        menu = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input, pelase try again...");
                        break;
                }
            }                                                                           
                                                                              // 23 September 2020. Isac Hellström. \\
        }                                                                    // 23 September 2020. Isac Hellström. \\
        public  void AddChildrensBook()           // 23 September 2020. Isac Hellström. \\
        {
            ChildrensBook x = new ChildrensBook();

            // 23 September 2020. Isac Hellström. \\
            //Console.WriteLine("Please name the instance of the class: ");
            //string namOfObject = Console.ReadLine();
            //ChildrensBook namOfObject = new ChildrensBook();

            Console.WriteLine("Please name the Author: ");
            x.Author = Console.ReadLine();

            Console.WriteLine("Please name how many pages it contains: ");
            x.AmountOfPages = int.Parse(Console.ReadLine());

            Console.WriteLine("Please name it's Title: ");
            x.Name = Console.ReadLine();

            Console.WriteLine("Please name its age restriction");
            x.AgeRecommendation = int.Parse(Console.ReadLine());

            Console.WriteLine("is it a picture book? Y/N");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
                x.IsPictureBook = true;
            else
                x.IsPictureBook = false;

            // Fråga Håkan: lös denna med Ternary <---------------- !! \\
            //   childrensBook.IsPictureBook == true: childrensBook.IsPictureBook == false ;  \\
            Console.WriteLine("Your book has been created and stored in the library.");

            Console.ReadLine();
            Console.Clear();
            books.Add(x);
        }

        public void AddFictionalBook(FictionalBook fictionalBook)
        {
            Console.WriteLine("Please name the Author: ");
            fictionalBook.Author = Console.ReadLine();

            Console.WriteLine("Please name how many pages it contains: ");
            fictionalBook.AmountOfPages = int.Parse(Console.ReadLine());

            Console.WriteLine("Please name it's Title: ");
            fictionalBook.Name = Console.ReadLine();

            Console.WriteLine("Please name its fantasy-genre");
            fictionalBook.FantasyGenre = Console.ReadLine();

            Console.WriteLine("is it an anthology? Y/N");
            string input = Console.ReadLine().ToLower();
             //     bool ? första alt: andra alt;     <------ Ternary Base.
            if (input == "y")
                fictionalBook.IsAnthology = true;
            else
                fictionalBook.IsAnthology = false;

            // Fråga Håkan: lös denna med Ternary <---------------- !! \\
            //   childrensBook.IsPictureBook == true: childrensBook.IsPictureBook == false ;  \\
            Console.WriteLine("Your book has been created and stored in the library.");
            Console.ReadLine();
            Console.Clear();

            books.Add(fictionalBook);
        }
        public void AddAcademicBook(AcademicBook academicbook)
        {

            Console.WriteLine("Please name the Author: ?");
            academicbook.Author = Console.ReadLine();

            Console.WriteLine("Please name how many pages it contains: ");
            academicbook.AmountOfPages = int.Parse(Console.ReadLine());

            Console.WriteLine("Please name it's Title: ");
            academicbook.Name = Console.ReadLine();

            Console.WriteLine("Please name its subject: ");
            academicbook.Subject = Console.ReadLine();

            Console.WriteLine("Please enter its intricacy lvl: (1-4)");
            academicbook.Intricacy = int.Parse(Console.ReadLine());

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Your book has been created and stored in the library.");
            books.Add(academicbook);
        }
        public void GetBasicSpecs(Book book)
        {
            Console.WriteLine($"Amount of pages: {book.AmountOfPages}\n" +
                 $"Book name: {book.Name}\n" +
                 $"Book author: {book.Author}\n");
        }
        public void GetMoreSpecs(Book book)
        {
            book.ReadBlurb();
        }
        public void SortBooks()
        {
            Console.WriteLine("Books have been sorted in alphabetic order");
            books.Sort();
        }
        public void PrintBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Name}");
            }

        }
    }




}
