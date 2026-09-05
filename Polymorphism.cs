// polymorphism is a two main concepts 
// 1. Compile time polymorphism (method overloading);
// 2. Run time polymorphism (method overriding);


class Polymorphism
{
    public virtual void PolymorphismPractice()
    {
        Console.WriteLine($"This is Base class");
    }
}

class DerivedClass : Polymorphism
{
    public override void PolymorphismPractice()
    {
       Console.WriteLine($"This is Derived Class .");
       
    }
}