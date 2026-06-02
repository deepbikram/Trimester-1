// use array to read marks and arrange them in ascending order withou using foreach loop



class Program
{    static void Main()
    {
        Console.WriteLine("Enter the number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] marks = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter marks for student {i + 1}: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(marks);
        Console.WriteLine("Marks in ascending order:");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine(marks[i]);
        }
    }
}
