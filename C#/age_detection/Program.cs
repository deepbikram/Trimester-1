class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 0 && age < 18) {
            Console.WriteLine("Go to study.");
        } else if (age < 55 && age >= 18) {
            Console.WriteLine("You are allowed to party");
        } else if (age > 55 && age < 125) {
            Console.WriteLine("You, go to sleep.");
        }
        else
        {
            Console.WriteLine("Invalid age.");
        }
    }
}
