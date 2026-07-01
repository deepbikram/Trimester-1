using System;

// Base class (Grandparent)
public class Toy
{
    public string Name;
    
    public Toy(string name)
    {
        Name = name;
        Console.WriteLine($"Creating a new toy: {Name}");
    }
    
    public void Play()
    {
        Console.WriteLine($"Playing with {Name}!");
    }
}

// First branch: Vehicle toys (Single inheritance from Toy)
public class Car : Toy
{
    public string Color;
    
    public Car(string name, string color) : base(name)
    {
        Color = color;
    }
    
    public void Drive()
    {
        Console.WriteLine($"{Name} the {Color} car is driving: Vroom vroom!");
    }
    
    public void Honk()
    {
        Console.WriteLine($"{Name} goes: Beep beep!");
    }
}

// Second branch: Building toys (Single inheritance from Toy)
public class BuildingBlock : Toy
{
    public int NumberOfPieces;
    
    public BuildingBlock(string name, int pieces) : base(name)
    {
        NumberOfPieces = pieces;
    }
    
    public void Build()
    {
        Console.WriteLine($"Building something with {Name} ({NumberOfPieces} pieces)!");
    }
    
    public void Stack()
    {
        Console.WriteLine($"Stacking {Name} blocks together!");
    }
}

// Third branch: Doll toys (Single inheritance from Toy)
public class Doll : Toy
{
    public int HeightInCentimeters;
    
    public Doll(string name, int height) : base(name)
    {
        HeightInCentimeters = height;
    }
    
    public void Dress()
    {
        Console.WriteLine($"Dressing up {Name} the doll!");
    }
    
    public void Hug()
    {
        Console.WriteLine($"Giving {Name} a big hug!");
    }
}

// HYBRID INHERITANCE EXAMPLE 1: 
// TransformingCar inherits from Car AND can do doll-like things
// This is Multiple Inheritance + Single Inheritance = Hybrid
public class TransformingCar : Car
{
    public string RobotName;
    
    public TransformingCar(string name, string color, string robotName) : base(name, color)
    {
        RobotName = robotName;
    }
    
    // Car features
    public void Transform()
    {
        Console.WriteLine($"{Name} transforms into {RobotName} the robot!");
    }
    
    // Robot features (like a doll - can be dressed/hugged)
    public void Pose()
    {
        Console.WriteLine($"{RobotName} strikes a heroic pose!");
    }
    
    public void Speak()
    {
        Console.WriteLine($"{RobotName} says: 'I am a transforming robot toy!'");
    }
}

// HYBRID INHERITANCE EXAMPLE 2:
// DollHouse inherits from BuildingBlock AND has Doll features
// This creates a combination of different toy categories
public class DollHouse : BuildingBlock
{
    public int NumberOfRooms;
    
    public DollHouse(string name, int pieces, int rooms) : base(name, pieces)
    {
        NumberOfRooms = rooms;
    }
    
    // Building features
    public void Assemble()
    {
        Console.WriteLine($"Assembling the {Name} dollhouse with {NumberOfPieces} pieces...");
    }
    
    // Doll-related features (can host dolls)
    public void PlaceDoll(Doll doll)
    {
        Console.WriteLine($"Placing {doll.Name} inside the {Name} dollhouse (Room {NumberOfRooms})!");
    }
    
    public void Decorate()
    {
        Console.WriteLine($"Decorating the {Name} dollhouse with furniture!");
    }
}

// HYBRID INHERITANCE EXAMPLE 3:
// RemoteControlCar inherits from Car (single) but also has features 
// that combine with BuildingBlock concepts (through composition, but showing hybrid idea)
public class RemoteControlCar : Car
{
    public int BatteryLife;
    public BuildingBlock AttachedBlock;
    
    public RemoteControlCar(string name, string color, int battery) : base(name, color)
    {
        BatteryLife = battery;
    }
    
    public void RemoteDrive()
    {
        Console.WriteLine($"Controlling {Color} {Name} with remote! Battery: {BatteryLife}%");
    }
    
    public void AttachBlock(BuildingBlock block)
    {
        AttachedBlock = block;
        Console.WriteLine($"Attached {block.Name} to the {Name} car!");
    }
    
    public void BuildWithAttachedBlock()
    {
        if (AttachedBlock != null)
        {
            Console.WriteLine($"Using {AttachedBlock.Name} while driving {Name}!");
            AttachedBlock.Stack();
        }
    }
}

// Main program demonstrating hybrid inheritance
public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== TOY BOX HYBRID INHERITANCE DEMO ===\n");
        
        // Regular toys (single inheritance)
        Console.WriteLine("--- Regular Toys ---");
        Car myCar = new Car("Ferrari", "Red");
        myCar.Drive();
        myCar.Honk();
        
        Doll myDoll = new Doll("Barbie", 18);
        myDoll.Dress();
        myDoll.Hug();
        
        BuildingBlock myBlocks = new BuildingBlock("LEGO Set", 500);
        myBlocks.Build();
        myBlocks.Stack();
        
        Console.WriteLine("\n--- HYBRID TOYS (Combining Features) ---");
        
        // HYBRID EXAMPLE 1: Transforming Car (Car + Robot/Doll features)
        Console.WriteLine("\n1. Transforming Car Robot:");
        TransformingCar optimus = new TransformingCar("Truck", "Blue", "Optimus Prime");
        optimus.Drive();        // From Car
        optimus.Honk();         // From Car
        optimus.Transform();    // Own method
        optimus.Pose();         // Like a doll feature
        optimus.Speak();        // Own method
        optimus.Play();         // From Toy (grandparent)
        
        // HYBRID EXAMPLE 2: Dollhouse (Building + Doll features)
        Console.WriteLine("\n2. Dollhouse (Building Blocks + Doll Hosting):");
        DollHouse dreamHouse = new DollHouse("Dream Mansion", 1000, 5);
        dreamHouse.Assemble();      // Building feature
        dreamHouse.Decorate();      // Own method
        dreamHouse.PlaceDoll(myDoll); // Combines with Doll
        dreamHouse.Stack();         // From BuildingBlock
        
        // HYBRID EXAMPLE 3: Remote Control Car with Building Blocks
        Console.WriteLine("\n3. Remote Control Car with LEGO Attachment:");
        RemoteControlCar rcCar = new RemoteControlCar("RC Racer", "Green", 85);
        rcCar.RemoteDrive();        // Own method
        rcCar.AttachBlock(myBlocks); // Combining car + building block
        rcCar.BuildWithAttachedBlock(); // Using both features
        rcCar.Drive();              // From Car
        
        Console.WriteLine("\n=== HYBRID INHERITANCE EXPLANATION ===");
        Console.WriteLine("✓ TransformingCar: Combines Car (vehicle) + Robot (doll-like) features");
        Console.WriteLine("✓ DollHouse: Combines BuildingBlock (construction) + Doll hosting");
        Console.WriteLine("✓ RemoteControlCar: Car + Building block attachment capability");
        Console.WriteLine("\nThis is HYBRID because we mix:");
        Console.WriteLine("- Single inheritance (Toy → Car → TransformingCar)");
        Console.WriteLine("- Multiple inheritance concepts (combining different toy categories)");
        Console.WriteLine("- Hierarchical structure (Toy has multiple children: Car, Doll, BuildingBlock)");
    }
}