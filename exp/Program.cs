class Program
{
    static void Main()
    {
        SortedList<int, string> students = new SortedList<int, string>(); // Create a SortedList to store roll numbers and names
        while (true)
        {
            Console.Write("Enter roll number (or 'q' to quit): ");
            string rollInput = Console.ReadLine();
            if (rollInput.Trim().ToLower() == "q") //trim --> spaces trim, to lower --> lowercase
                break;
            if (!int.TryParse(rollInput, out int rollNo)) // Try to parse the input as an integer
            {
                Console.WriteLine("Invalid roll number. Try again.");
                continue;
            }
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            name = name.ToUpper(); // Convert name to uppercase
            if (students.ContainsKey(rollNo)) // Check if roll number already exists
            {
                Console.WriteLine("Roll number already exists. Try again.");
                continue;
            }
            students.Add(rollNo, name);
        }
        Console.WriteLine("\nSorted list of students:");
        foreach (var student in students) // Prints sorted list and print roll number and name
        {
            Console.WriteLine(student.Key + " " + student.Value);
        }
    }
}
