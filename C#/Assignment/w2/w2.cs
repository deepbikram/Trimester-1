/* Instructions

Variable Playground: Create a new project "Week2Lab"  : 
Take input: Name, age, height and calculate age in months i.e.(age*12), calculate days lived (approx. age * 365) 
Add input for favorite food and display it, calculate year of birth (2026 - age), Ask for temperature in Celsius, convert to Fahrenheit
Create a program that: 
Pre fix two numbers like int fN = 10; sN =20; 
Calculates and displays: 
 Sum 
Difference 
Product 
Quotient 
Remainder
Pizza Party Calculator

You're ordering pizza for a party. Write a program that: 

Asks how many people are attending 

Asks how many slices each person will eat 

Asks how many slices per pizza 

Calculates: 

Total slices needed 

Number of pizzas needed (round up!) 

Total cost (assuming Rs:200 per pizza)
    */

internal class Week2Lab
{
    static void Main()
    {
        // Asking input from the user
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your height in cm: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculations
        int ageInMonths = age * 12;
        int daysLived = age * 365;
        int yearOfBirth = 2026 - age; 

        // Showing output
        Console.Write("Enter your favorite food: ");
        string favoriteFood = Console.ReadLine();

        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age in months: {ageInMonths}");
        Console.WriteLine($"Days lived (approx.): {daysLived}");
        Console.WriteLine($"Year of birth: {yearOfBirth}");
        Console.WriteLine($"Favorite food: {favoriteFood}");
        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");

        // Pre fix two numbers and calculate sum, difference, product, quotient, remainder
        int fN = 10;
        int sN = 20;
        int sum = fN + sN;
        int difference = fN - sN;
        int product = fN * sN;
        double quotient = (double)fN / sN;
        int remainder = fN % sN;

        // Showing output for calculations
        Console.WriteLine($"First Number: {fN}");
        Console.WriteLine($"Second Number: {sN}");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");
        Console.WriteLine($"Remainder: {remainder}");

        // Asking input for Pizza Party Calculator
        Console.Write("How many people are attending the party? ");
        int peopleAttending = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many slices will each person eat? ");
        int slicesPerPerson = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many slices are there per pizza? ");
        int slicesPerPizza = Convert.ToInt32(Console.ReadLine());

        // Calculations
        int totalSlicesNeeded = peopleAttending * slicesPerPerson;
        int pizzasNeeded = (int)Math.Ceiling((double)totalSlicesNeeded / slicesPerPizza);
        int totalCost = pizzasNeeded * 200;

        // Showing output for pizza party
        Console.WriteLine($"Total slices needed: {totalSlicesNeeded}");
        Console.WriteLine($"Number of pizzas needed: {pizzasNeeded}");
        Console.WriteLine($"Total cost (Rs:200 per pizza): Rs:{totalCost}");
    }
}