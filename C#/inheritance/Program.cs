// Imagine you have a toy box, and inside that toy box, you have different types of toys. Each type of toy has its own special features, but they all share some common things like being toys.

//cr cat toy 
public class Toy
{
    public string Name;

    // // Constr to intl the name of the toy -->
    public Toy(string name)
    {
        Name = name;
    }
}

public class Car : Toy
{
    public string Color;

    // Constructor to initialize the name and color of the car
    public Car(string name, string color) : base(name)
    {
        Color = color;
    }
}

public class Doll : Toy
{
    public int HeightInCentimeters;

    // Constructor to initialize the name and height of the doll
    public Doll(string name, int height) : base(name)
    {
        HeightInCentimeters = height;
    }
}

public class Program
{
    public static void Main()
    {
        // Creating a Car object
        Car myCar = new Car("Ferrari", "Red");
        Console.WriteLine($"My car is {myCar.Color} and named {myCar.Name}");

        // Creating a Doll object
        Doll myDoll = new Doll("Barbie", 18);
        Console.WriteLine($"My doll is named {myDoll.Name} and is {myDoll.HeightInCentimeters} cm tall");
    }
}
