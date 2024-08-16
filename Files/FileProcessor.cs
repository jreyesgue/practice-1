namespace Practice1.Files
{
    public class FileProcessor
    {
        public static void Start()
        {
            Console.Write("\nPlease enter a file path: ");
            string path = Console.ReadLine() ?? string.Empty;

            if (File.Exists(path))
            {
                SortFile(path);
            }
            else
            {
                Console.WriteLine("\nError: The file does not exist.\n");
            }
        }

        private static void SortFile(string path)
        {
            List<string> names = File.ReadLines(path).ToList();
            string sortedPath = Path.GetDirectoryName(path) + @"\Sorted-Names.txt";
            names.Sort();

            File.WriteAllLines(sortedPath, names);
            Console.WriteLine("\nA new file has been created in: " + sortedPath);
            Console.WriteLine();
        }
    }
}
