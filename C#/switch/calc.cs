System.Console.WriteLine("Enter two numbers: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter an operator (+, -, *, /): ");
char op = Convert.ToChar(Console.ReadLine());

switch (op)
{
    case '+':
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        break;
    case '-':
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        break;
    case '*':
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        break;
    case '/':
        if (num2 != 0)
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        else
            Console.WriteLine("Division by zero is not allowed.");
        break;
    default:
        Console.WriteLine("Invalid operator. Try again.");
        break;
}