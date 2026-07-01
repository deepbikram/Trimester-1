using System;

abstract class Toy
{
    // Complete method - same for all toys
    public void Package()
    {
        Console.WriteLine("Putting toy in a box 📦");
    }
    
    // Complete method - same for all toys
    public void AddPriceTag()
    {
        Console.WriteLine("Adding price tag: $10 💲");
    }
    
    // Abstract method - EACH toy makes DIFFERENT sound
    public abstract void MakeSound();
}

// Toy 1: Teddy Bear
class TeddyBear : Toy
{
    public override void MakeSound()
    {
        Console.WriteLine("🧸 Hug me! I say: Grrr... I'm cute!");
    }
}

// Toy 2: Toy Car
class ToyCar : Toy
{
    public override void MakeSound()
    {
        Console.WriteLine("🚗 Vroom! Vroom! Beep beep!");
    }
}

// Toy 3: Rubber Duck
class RubberDuck : Toy
{
    public override void MakeSound()
    {
        Console.WriteLine("🦆 Quack! Quack! I'm yellow!");
    }
}

// Toy 4: Drum
class Drum : Toy
{
    public override void MakeSound()
    {
        Console.WriteLine("🥁 Boom! Boom! Bang!");
    }
}

