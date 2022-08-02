using System;

namespace HeadFirstDesignPatterns;

public abstract class Duck
{

    public Duck() { }
    
    public virtual void Quack()
    {
        Console.WriteLine("Quack");
    }

    public void Swim()
    {
        Console.WriteLine("Swimming...");
    }

    public void Fly()
    {
        Console.WriteLine("I'm Flying!!!");
    }

    public abstract void Display();
}


public class MallardDuck : Duck
{
    public override void Display()
    {
        Console.WriteLine("I'm a Mallard Duck!");
    }
}

public class RedheadDuck : Duck
{
    public override void Display()
    {
        Console.WriteLine("I'm a Redhead Duck!");
    }
}

public class RubberDuck : Duck
{
    public override void Quack()
    {
        Console.WriteLine("Squeak");
    }
    public override void Display()
    {
        Console.WriteLine("I'm a Rubber Duck");
    }
}