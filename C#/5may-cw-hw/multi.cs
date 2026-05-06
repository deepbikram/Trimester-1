//multiplication table using do-while loop

using System;

int product = 1;
int input;

do 
{
    Console.WriteLine("Enter a number to see its multiplication table (or 0 to exit): ");
    input = Convert.ToInt32(Console.ReadLine());

    if (input != 0)
    {
        Console.WriteLine($"Multiplication Table for {input}:");
        for (int i = 1; i <= 10; i++)
        {
            product = input * i;
            Console.WriteLine($"{input} x {i} = {product}");
        }
        Console.WriteLine(); // Add an empty line for better readability
    }
} while (input != 0);

Console.WriteLine("Program terminated.");
Console.WriteLine($"Total Product: {product}");