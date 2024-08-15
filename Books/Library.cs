namespace Practice1.Books
{
    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = [];
        }

        public void Start()
        {
            bool finish = false;

            do
            {
                DisplayMenu();

                switch (GetOption())
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        RemoveBook();
                        break;
                    case 3:
                        DisplayBooks();
                        break;
                    case 4:
                        Console.WriteLine("\nReturning to the main menu...\n");
                        finish = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Try Again.");
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
            Console.WriteLine("\n--- Library Menu ---\n");
            Console.WriteLine("1. Add Book.");
            Console.WriteLine("2. Remove Book.");
            Console.WriteLine("3. Display All Books.");
            Console.WriteLine("4. Exit.");
        }

        private void AddBook()
        {
            Console.Write("\nPlease enter the book title: ");
            string bookTitle = Console.ReadLine() ?? string.Empty;
            Console.Write("Now enter the book author: ");
            string bookAuthor = Console.ReadLine() ?? string.Empty;
            Console.Write("Finally, enter the book ISBN: ");
            string bookISBN = Console.ReadLine() ?? string.Empty;

            books.Add(new Book(bookTitle, bookAuthor, bookISBN));
        }

        private void RemoveBook()
        {
            Console.Write("\nEnter the book ISBN: ");
            string deleteISBN = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("\nRemoving book " + deleteISBN);

            books.RemoveAll(book => book.ISBN == deleteISBN);
        }

        private void DisplayBooks()
        {
            Console.WriteLine("\n--- Book Details ---\n");
            books.ForEach(book => book.ShowDetails());
        }
    }
}
