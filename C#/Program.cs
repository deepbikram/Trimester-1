/* class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter your age: ");
        string age = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter your location: ");
        string location = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter your +2 School Name: ");
        string schoolName = Console.ReadLine() ?? string.Empty;

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"School Name: {schoolName}");
    }
} */

/* class ImplicitandExplicit
{
static void Main(string[] args)
    {
int a = 10;
int b = a;   // implicit --> gets the exact value whatever the input is 

double c = 9.5;
int d = (int)c;  // explicit --> gets the value defined by req. type

Console.WriteLine(b);  // 10 ans
Console.WriteLine(d);   // 9 and instead of 9.5
Console.WriteLine(a.GetType());
Console.WriteLine(c.GetType());
}
} */

/* class Program
{
    static void Main()
    {
        int num1 = 5, num2 = 10, num3 = 20;
        num1 += num2;  // num1 = num1 + num2
        num1 += num3;  // num1 = num1 + num3
        Console.WriteLine("actual value is " + num1); // total val of num1

        System.Console.WriteLine("final value is " + num1 + " second added value is " + num2 + " third added value is " + num3);
}
    }
*/
/* class Program
{
    static void Main(string[] args)
    {
        int num1 = 5, num2 = 10, num3 = 20;
        int add = num1 + num2 + num3,
            sub = num1 - num2 - num3,
            mul = num1 * num2 * num3,
            div = num1 / num2 / num3,
            mod = num1 % num2 % num3;

System.Console.WriteLine($" addition is {add}, subtraction is {sub}, multiplication is {mul}, division is {div}, modulus is {mod}");
    }
}
*/
/*
Core Math Library Features
The System.Math class contains several essential functions and properties: 
Mathematical Constants:
Math.PI: Represents the ratio of a circle's circumference to its diameter (approximately 3.14159).
Math.E: Represents the natural logarithmic base (approximately 2.71828).
Basic Arithmetic & General Functions:
Math.Abs(x): Returns the absolute (positive) value of a number.
Math.Max(x, y) / Math.Min(x, y): Finds the highest or lowest value between two numbers.
Math.Sqrt(x): Calculates the square root of a number.
Math.Pow(x, y): Raises a number x to the power of y.
Math.Clamp(value, min, max): Restricts a value to a specified range.
Math.Sign(x): Returns -1, 0, or 1 to indicate the sign of a number.
Rounding and Truncation:
Math.Round(x): Rounds a number to the nearest whole integer or specified decimal places.
Math.Ceiling(x): Rounds a number upwards to the nearest integer.
Math.Floor(x): Rounds a number downwards to the nearest integer.
Math.Truncate(x): Removes the fractional part of a number without rounding.
Trigonometric Functions:
Math.Sin(x) / Math.Cos(x) / Math.Tan(x): Calculates the sine, cosine, or tangent of an angle (in radians).
Math.Asin(x) / Math.Acos(x) / Math.Atan(x): Returns the arc (inverse) sine, cosine, or tangent of a number.
Logarithmic & Exponential:
Math.Log(x): Calculates the natural logarithm (base e).
Math.Log10(x): Calculates the base-10 logarithm.
Math.Exp(x): Returns e raised to the specified power. 
*/
/*class Program
{
        static void Main(string[] args)
    {
        double a = 5.5;
        double b = Math.Round(a, 3);
        Console.WriteLine(b);
}
}
*/
/*
class Program
{
    static void Main(string[] args)
    {
        int a = 10, b = 10;
        int c = a*b;
        int d = a/b;

        int maxVal = Math.Max(c, d); // Result should be  100
int minVal = Math.Min(c, d); // Result should be 1
System.Console.WriteLine($"the max value of {a} and {b} when multiplied is {maxVal} and when divided is {minVal}");
    }
}
*/

/*
class Program
{
    static void Main(string[] args)
    {
int[] numbers = { 5, 1, 9, 3, 7 };
int min = numbers[0];
int max = numbers[0];

for (int i = 1; i < numbers.Length; i++) {
    if (numbers[i] < min) min = numbers[i];
    if (numbers[i] > max) max = numbers[i];

System.Console.WriteLine($"The minimum value is: {min}");
System.Console.WriteLine($"The maximum value is: {max}");
}
}
}*/
/*
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        string input = Console.ReadLine();
        int a = Convert.ToInt32(input);

        Console.Write("Enter second number: ");
        input = Console.ReadLine();
        int b = Convert.ToInt32(input);

        int sum = a + b;
        Console.WriteLine($"Sum: {sum}");
    }
} */
/*
class Program
{
    static void Main()
    {
        Console.Write("Enter your email: ");
        string email = Console.ReadLine() ?? string.Empty;

        string lower = email.ToLower();
        Console.WriteLine($"Email in Lowercase: {lower}");
        
        string replace = email.Replace("@", "[at]");
        Console.WriteLine($"Email with @ replaced: {replace}");
    }
}
*/

class Program
{
    static void Main()
    {
       Console.Write(" Enter marks of Math: ");
       int mathMarks = Convert.ToInt32(Console.ReadLine());

       Console.Write(" Enter marks of Science: ");
       int scienceMarks = Convert.ToInt32(Console.ReadLine());

       Console.Write(" Enter marks of English: ");
       int englishMarks = Convert.ToInt32(Console.ReadLine());

         int totalMarks = mathMarks + scienceMarks + englishMarks;
         double percentage = (double)totalMarks / 3;

         if (percentage >= 90 && percentage <= 100)
            {
                Console.WriteLine("Grade: A");
            }
            else if (percentage >= 80 && percentage < 90)
            {
                Console.WriteLine("Grade: B");
            }
            else if (percentage >= 70 && percentage < 80)
            {
                Console.WriteLine("Grade: C");
            }
            else if (percentage >= 60 && percentage < 70)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
    }
}   

