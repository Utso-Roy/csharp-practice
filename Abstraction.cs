// abstraction 
abstract class Abstraction
{
    // This is an abstract method which does not have any implementation
       public abstract void Result();
}

class DerivedAbstraction : Abstraction
{
    public override void Result()
    {
        Console.WriteLine("This is Derived Class of Abstraction");
    }
}