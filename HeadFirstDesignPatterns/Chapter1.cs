using System;

namespace HeadFirstDesignPatterns;

public abstract class Duck
{

    public Duck() { }
    
    public void Quack()
    {
        Console.WriteLine("Quack");
    }

    public void Swim()
    {
        Console.WriteLine("Swimming...");
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