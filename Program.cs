﻿using Practice1.Bank;
using Practice1.Books;
using Practice1.Files;
using Practice1.School;
using Practice1.Text;
using Practice1.Time;
using Practice1.Weight;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finish = false;

            do
            {
                DisplayMenu();

                switch (GetOption())
                {
                    case 1:
                        BMI.Start();
                        break;
                    case 2:
                        var library = new Library();
                        library.Start();
                        break;
                    case 3:
                        var atm = new ATM(100);
                        atm.Start();
                        break;
                    case 4:
                        Grades.Start();
                        break;
                    case 5:
                        Dates.Start();
                        break;
                    case 6:
                        TextProcessor.Start();
                        break;
                    case 7:
                        FileProcessor.Start();
                        break;
                    case 8:
                        Console.WriteLine("\nGoodbye :)");
                        finish = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Try Again.\n");
                        break;
                }
            } while (!finish);
        }

        private static int GetOption()
        {
            Console.Write("\nSelect an option: ");

            return Convert.ToInt32(Console.ReadLine());
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("---------- Menu ----------\n");
            Console.WriteLine("1. Calculate BMI.");
            Console.WriteLine("2. Library.");
            Console.WriteLine("3. ATM.");
            Console.WriteLine("4. Student Grades.");
            Console.WriteLine("5. Compare Dates.");
            Console.WriteLine("6. Analyze Text.");
            Console.WriteLine("7. Sort File.");
            Console.WriteLine("8. Exit.");
        }
    }
}
