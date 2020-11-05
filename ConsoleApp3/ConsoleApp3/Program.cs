using System;

namespace SwitchCodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ange siffra, switch: ");
                int caseSwitch1 = int.Parse(Console.ReadLine());
                switch (caseSwitch1)
                {
                    case 1:
                        Console.WriteLine("Case 1");
                        break;

                    default:
                        break;
                }

                Console.WriteLine("---");

                Console.Write("Ange siffra, switch: ");
                int caseSwitch2 = int.Parse(Console.ReadLine());
                switch (caseSwitch2)
                {
                    case 1:
                        Console.WriteLine("Case 1");
                        break;
                    case 2:
                    case 3:
                        Console.WriteLine("Case 2 or 3");
                        break;
                    case 4:
                        Console.WriteLine("case 4");
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }

                Console.WriteLine("---");

                Console.Write("Ange namn: ");
                string name = Console.ReadLine();

                switch (name)
                {
                    case "micke":
                    case "håkan":
                        Console.WriteLine("Lärare");
                        break;
                    case "christer":
                        Console.WriteLine("Chefen");
                        break;
                    default:
                        Console.WriteLine("elev");
                        break;
                }

                Console.WriteLine("----------------------------");

                //  -- ! TRY PARSE ! -- \\
                  //  --------------  \\

                Console.WriteLine("Ange siffra, TryParse");
                string input3 = Console.ReadLine();
                int number;
                
                bool success = int.TryParse(input3, out number);

                if (success)
                {
                    Console.WriteLine($"Converted {input3} to {number} ");
                }
                else
                {
                    Console.WriteLine($"Attempted conversion of {input3} failed.");
                }

                          // -- !! PATTERN MATCHING !! -- \\
                              // -----------------  \\

                            //int input = int.Parse(Console.ReadLine());   
                            //string testString = input switch
                            //{
                            //    _ when input >= 3 && input <= 7 => "Mellan 3 & 7",
                            //    _ => "Annat value"

                            //};
                            //Console.WriteLine(testString);


                            //switch pattern - matching:
                            //int test = 5;
                            //switch (test)
                            //{
                            //    case int i when (i >= 4 && i <= 7):
                            //        break;
                            //}

            }
        }
    }
}
