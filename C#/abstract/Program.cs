// Abstract = "Incomplete" or "Idea-only" - something that cannot exist by itself, only as a concept.
//All abstraction IS inheritance, but NOT all inheritance is abstraction.

abstract class Car
{
    public abstract string GetColor();  // Parent: "I have NO color"
}

// Ferrari - child PROVIDES its own color
class Ferrari : Car
{
    public override string GetColor()
    {
        return "Red";  // Ferrari: "My color is Red"
    }
}

class Program
{
    static void Main()
    {
        Ferrari myFerrari = new Ferrari();
        Console.WriteLine($"Ferrari color: {myFerrari.GetColor()}");  // Red
    }
}