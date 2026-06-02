// Imagine you have a toy box, and inside that toy box, you have different types of toys. Each type of toy has its own special features, but they all share some common things like being toys.

public class Toy
{
    public string Name { get; set; }
    public string Color { get; set; }
    // Constr to intl the name of the toy -->
    public Toy(string name, string color)
    {
        Name = name;
        Color = color;
    }
}

public class Car : Toy
{
    public int Age { get; set; }

    // Constructor to initialize the name and age of the car
    public Car(string name, string color, int age) : base(name, color)
    {
        Age = age;
    }
}

public class Doll : Toy
{
    public int HeightInCentimeters { get; set; }

    // Constructor to initialize the name and height of the doll
    public Doll(string name, string color, int height) : base(name, color) 
    {
        HeightInCentimeters = height;
    }
}

public class Program
{
    public static void Main()
    {
        Car myCar = new Car("Ferrari", "Red", 19);
        Console.WriteLine($"My {myCar.Name} is {myCar.Color} and age {myCar.Age}");

        Doll myDoll = new Doll("Barbie", "Pink", 18);
        Console.WriteLine($"My {myDoll.Name} is of color {myDoll.Color} which is {myDoll.HeightInCentimeters} cm tall");
    }
}
