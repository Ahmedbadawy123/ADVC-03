namespace AssignmentADVC03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager

            // Create a program that manages student grades using One Of Collections

            List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            Console.WriteLine("All Grades: " + string.Join(", ", grades));
            Console.WriteLine($"Count: {grades.Count}");
            Console.WriteLine($"First Grade: {grades[0]}");
            Console.WriteLine($"Last Grade: {grades[grades.Count - 1]}");

            grades.Sort();
            Console.WriteLine("Sorted Grades (Ascending): " + string.Join(", ", grades));

            int firstAbove90 = grades.Find(g => g > 90);
            Console.WriteLine($"First grade above 90: {firstAbove90}");

            List<int> failingGrades = grades.FindAll(g => g < 75);
            Console.WriteLine("Failing grades (< 75): " + string.Join(", ", failingGrades));

            grades.RemoveAll(g => g < 75);
            Console.WriteLine("Grades after removing failing: " + string.Join(", ", grades));

            bool has100 = grades.Contains(100);
            Console.WriteLine($"Contains 100: {has100}");

            List<string> formattedGrades = grades.ConvertAll(g => $"Grade: {g}");
            Console.WriteLine("Formatted Grades: " + string.Join(" | ", formattedGrades));


            #endregion

        }
    }
}
