using System.Text;

namespace Practice1.Text
{
    public class TextProcessor
    {
        public static void Start()
        {
            Console.WriteLine("\nReminder: Press enter three times to finish.");
            Console.WriteLine("\nPlease enter your text here:\n");

            CountValues(ReadText());
        }

        private static string ReadText()
        {
            int emptyLines = 0;
            string line;
            StringBuilder input = new StringBuilder();

            while (emptyLines < 2)
            {
                line = Console.ReadLine() ?? string.Empty;
                input.AppendLine(line);

                if (string.IsNullOrWhiteSpace(line))
                {
                    emptyLines++;
                }
                else
                {
                    emptyLines = 0;
                }
            }

            return input
                .Replace("\r", "")
                .Remove(input.Length - 3, 3)
                .ToString();
        }

        private static void CountValues(string text)
        {
            int wordCount = text.Split([' ', '\n'], StringSplitOptions.RemoveEmptyEntries).Length;
            int sentenceCount = text.Split(['.', '!', '?'], StringSplitOptions.RemoveEmptyEntries).Length;
            int paragraphCount = text.Split("\n\n", StringSplitOptions.RemoveEmptyEntries).Length;

            Console.WriteLine("Word count: " + wordCount);
            Console.WriteLine("Sentence count: " + sentenceCount);
            Console.WriteLine("Paragraph count: " + paragraphCount);
            Console.WriteLine();
        }
    }
}
