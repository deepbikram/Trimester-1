internal class Function
{
    static decimal Add(decimal a, decimal b)
    {
        Console.WriteLine("Adding " + a + " and " + b);
        return a + b;
    }
    // Overloading the Add function
    static decimal Add(decimal a, decimal b, decimal c)
    {
        Console.WriteLine("Adding " + a + ", " + b + " and " + c);
        return a + b + c;
    }
    static decimal Subtract(decimal a, decimal b)
    {
        Console.WriteLine("Subtracting " + b + " from " + a);
        return a - b;
    }
    static decimal Multiply(decimal a, decimal b)
    {
        Console.WriteLine("Multiplying " + a + " and " + b);
        return a * b;
    }
    static decimal Divide(decimal a, decimal b)
    {
        Console.WriteLine("Dividing " + a + " by " + b);
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero!");
            return 0;
        }
        return a / b;
    }
    static void Main(string[] args)
    {
         Console.WriteLine("Enter first number:");
         decimal num1 = Convert.ToDecimal(Console.ReadLine());
         
         Console.WriteLine("Enter second number:");
         decimal num2 = Convert.ToDecimal(Console.ReadLine());
        
         Console.WriteLine("Enter third number:");
         decimal num3 = Convert.ToDecimal(Console.ReadLine());

         decimal result = Add(num1, num2);
         Console.WriteLine("Result: " + result);

         // Overloaded function
         result = Add(num1, num2, num3);
         Console.WriteLine("Result: " + result);

         result = Subtract(num1, num2);
         Console.WriteLine("Result: " + result);

        result = Multiply(num1, num2);
        Console.WriteLine("Result: " + result);

        result = Divide(num1, num2);
        Console.WriteLine("Result: " + result);
    }    
}