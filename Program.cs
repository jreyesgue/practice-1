using Practice1.Books;

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
                        // TODO: Implement ATM Functionality
                        break;
                    case 4:
                        // TODO: Implement Students Functionality
                        break;
                    case 5:
                        // TODO: Implement Dates Functionality
                        break;
                    case 6:
                        // TODO: Implement Texts Functionality
                        break;
                    case 7:
                        // TODO: Implement Files Functionality
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
            Console.WriteLine("3. Control Flow.");
            Console.WriteLine("4. Arrays and Lists.");
            Console.WriteLine("5. Working with Dates.");
            Console.WriteLine("6. Working with Text.");
            Console.WriteLine("7. Working with Files.");
            Console.WriteLine("8. Exit.");
        }
    }
}
