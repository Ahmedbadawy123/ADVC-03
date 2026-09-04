namespace AssignmentADVC03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager

            // Create a program that manages student grades using One Of Collections

            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //Console.WriteLine("All Grades: " + string.Join(", ", grades));
            //Console.WriteLine($"Count: {grades.Count}");
            //Console.WriteLine($"First Grade: {grades[0]}");
            //Console.WriteLine($"Last Grade: {grades[grades.Count - 1]}");

            //grades.Sort();
            //Console.WriteLine("Sorted Grades (Ascending): " + string.Join(", ", grades));

            //int firstAbove90 = grades.Find(g => g > 90);
            //Console.WriteLine($"First grade above 90: {firstAbove90}");

            //List<int> failingGrades = grades.FindAll(g => g < 75);
            //Console.WriteLine("Failing grades (< 75): " + string.Join(", ", failingGrades));

            //grades.RemoveAll(g => g < 75);
            //Console.WriteLine("Grades after removing failing: " + string.Join(", ", grades));

            //bool has100 = grades.Contains(100);
            //Console.WriteLine($"Contains 100: {has100}");

            //List<string> formattedGrades = grades.ConvertAll(g => $"Grade: {g}");
            //Console.WriteLine("Formatted Grades: " + string.Join(" | ", formattedGrades));


            #endregion

            #region Exercise 2: Leaderboard

            // Create a leaderboard that automatically sorts players by score.

            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>()
            //{
            //    { 500, "Ahmed"},
            //    { 200, "Sara" },
            //    { 800, "Ali" },
            //    { 350, "Mona" }
            //};

            //Console.WriteLine("The Leaderboard:");
            //foreach (var board in leaderboard)
            //{
            //    Console.WriteLine($"Score: {board.Key} -> Player: {board.Value}");
            //}

            //int firstKey = leaderboard.Keys.First();
            //string firstValue = leaderboard.Values.First();
            //Console.WriteLine($"First Key: {firstKey}, First Value: {firstValue}");

            //bool score500Exists = leaderboard.ContainsKey(500);
            //Console.WriteLine($"Score 500 exists: {score500Exists}");

            //if (leaderboard.TryGetValue(999, out string player999))
            //{
            //    Console.WriteLine($"Player with score 999: {player999}");
            //}
            //else
            //{
            //    Console.WriteLine("Score 999 not found safely.");
            //}

            //leaderboard.Remove(200);
            //Console.WriteLine("\n Leaderboard after removing score 200 ");
            //foreach (var board in leaderboard)
            //{
            //    Console.WriteLine($"Score: {board.Key} -> Player: {board.Value}");
            //}

            // Helping With Ai and I Understand The Code.

            #endregion

            #region Exercise 3: Phone Book

            //Build a phone book application.

            //    Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            //{
            //    { "Ahmed", "01097496709" },
            //    { "Haneen", "01024314047" },
            //    { "Arwa", "01210122996" },
            //    { "Yara", "01007096234" }
            //};

            //    phoneBook["Haneen"] = "01005125143";
            //    phoneBook["Ahmed"] = "01099999999";

            //    try
            //    {
            //        phoneBook.Add("Sara", "01173627673"); 
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine($"[Caught Exception] Error adding duplicate: {ex.Message}");
            //    }

            //    bool isAdded = phoneBook.TryAdd("Sara", "01100000000");
            //    Console.WriteLine($"TryAdd duplicate 'Sara' result: {isAdded}");

            //    bool exists = phoneBook.ContainsKey("Khaled");
            //    Console.WriteLine($"Contact 'Khaled' exists: {exists}");

            //    if (phoneBook.TryGetValue("Khaled", out string phoneNumber))
            //    {
            //        Console.WriteLine($"Phone: {phoneNumber}");
            //    }
            //    else
            //    {
            //        phoneNumber = "Not Found";
            //        Console.WriteLine($"Khaled's contact: {phoneNumber}");
            //    }

            //    Console.WriteLine("All Keys: " + string.Join(", ", phoneBook.Keys));
            //    Console.WriteLine("All Values: " + string.Join(", ", phoneBook.Values));

            #endregion

            #region Exercise 4: Unique Email Validator

            // Use Collection to manage unique email addresses.

            HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            emails.Add("ahmed@test.com");
            emails.Add("AHMED@test.com");
            emails.Add("sara@test.com");
            emails.Add("Sara@Test.Com");

            Console.WriteLine($"Unique emails count: {emails.Count}");
            Console.WriteLine("Stored Emails: " + string.Join(", ", emails));

            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            HashSet<int> unionSet = new HashSet<int>(setA);
            unionSet.UnionWith(setB);
            Console.WriteLine("\nUnionWith (A U B): " + string.Join(", ", unionSet));

            HashSet<int> intersectSet = new HashSet<int>(setA);
            intersectSet.IntersectWith(setB);
            Console.WriteLine("IntersectWith (A ∩ B): " + string.Join(", ", intersectSet));

            HashSet<int> exceptSet = new HashSet<int>(setA);
            exceptSet.ExceptWith(setB);
            Console.WriteLine("ExceptWith (A - B): " + string.Join(", ", exceptSet));

            HashSet<int> subSet = new HashSet<int> { 1, 2 };
            bool isSubset = subSet.IsSubsetOf(setA);
            Console.WriteLine($"\nIs {{1, 2}} a subset of Set A? {isSubset}");

            #endregion
        }
    }
}
