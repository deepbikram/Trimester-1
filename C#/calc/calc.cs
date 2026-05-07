//c# program to demonstrate for loop and switch case with a project of calculator that can add, subtract, multiplication, division, modulus and quit the program. Enter 2 numbers and select the operation to perform.
class Program
{
    static void Main()
    {
        int choose;
        for (int i = 0; i < 1; i++)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Calculator");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Modulus");
            Console.WriteLine("6. Quit");
            Console.WriteLine("------------------------------");
            Console.Write("Select an option (1-6): ");
            choose = Convert.ToInt32(Console.ReadLine());

            if (choose >= 1 && choose <= 5)
            {
                Console.WriteLine("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        else
                        {
                            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        }
                        break;
                    case 5:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Modulus by zero is not allowed.");
                        }
                        else
                        {
                            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                        }
                        break;
                }
            }
            else if (choose == 6)
            {
                Console.WriteLine("Quitting...");
            }
            else
            {
                Console.WriteLine("Choose a valid option from the menu.");
            }
        }
    }
}