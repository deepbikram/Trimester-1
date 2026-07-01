// ========== ABSTRACT CLASS ==========     // ========== INTERFACE ==========

abstract class Animal                         interface I{Animal} 
{                                             {
    public abstract void/str. MakeSound();             void MakeSound();
                                               
    public void Sleep()                         
    {                                          
        Console.WriteLine("Zzz");
    }
}                                             }

// ========== USING THEM ==========          // ========== USING THEM ==========

class Dog : Animal                            class Dog : I{Animal}
{                                             {
    public override void MakeSound()              public void MakeSound()
    {                                             {
        Console.WriteLine("Woof");                    Console.WriteLine("Woof");
    }                                             }
}                                             }


interface IAnimal --> interface
interface Animal --> class