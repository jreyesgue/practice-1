namespace Practice1.School
{
    public class Grades
    {
        public static void Start()
        {
            var grades = new List<float>();

            Console.Write("\nPlease enter the number of students for your class: ");
            int students = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            FillAndSortGrades(students, grades);
            ShowReportCard(grades);
        }

        private static void FillAndSortGrades(int students, List<float> grades)
        {
            for (int i = 0; i < students; i++)
            {
                Console.Write("Enter the student {0} grade: ", i + 1);
                grades.Add(Convert.ToSingle(Console.ReadLine()));
            }

            grades.Sort();
        }

        private static void ShowReportCard(List<float> grades)
        {
            Console.WriteLine("\n---------- Class Report Card ----------\n");
            Console.WriteLine("Highest score: " + grades.Last());
            Console.WriteLine("Lowest score: " + grades.First());
            Console.WriteLine("Average grade: " + grades.Average());
            Console.WriteLine("Grades: " + string.Join(", ", grades));
            Console.WriteLine();
        }
    }
}
