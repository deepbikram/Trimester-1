// Simple marksheet using array and foreach
class Program
{
    static void Main(string[] args)
    {
        string[] subjects = { "Math", "Science", "English" };
        int count = 3;
        int[] marks = new int[count];
        int total = 0;

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter marks for {subjects[i]}: ");
            marks[i] = int.Parse(Console.ReadLine());
            total += marks[i];
        }

        Console.WriteLine("Marksheet:");
        for (int i = 0; i < count; i++)
        {
            string result = marks[i] < 40 ? "Fail" : "Pass";
            Console.WriteLine($"{subjects[i]}: {marks[i]} - {result}");
        }

        string overall = (total / count > 50) ? "Pass" : "Fail";
        Console.WriteLine($"Overall Result: {overall}");
    }
}