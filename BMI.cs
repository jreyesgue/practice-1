namespace Practice1
{
    public class BMI
    {
        public static void Start()
        {
            Console.Write("\nPlease enter your weight in kilograms: ");
            float weight = Convert.ToSingle(Console.ReadLine());

            Console.Write("Now enter your height in meters: ");
            float height = Convert.ToSingle(Console.ReadLine());

            float bmi = CalculateBMI(weight, height);
            string category = CalculateCategory(bmi);

            Console.WriteLine("\nYour BMI is: " + bmi.ToString("f"));
            Console.WriteLine("You are in the {0} category\n", category);
        }

        public static float CalculateBMI(float weight, float height)
        {
            return weight / (height * height);
        }

        public static string CalculateCategory(float bmi)
        {
            if (bmi < 18.5)
            {
                return "underweight";
            }
            else if (bmi < 25)
            {
                return "normal weight";
            }
            else if (bmi < 30)
            {
                return "overweight";
            }

            return "obesity";
        }
    }
}
