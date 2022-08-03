using System;

namespace HeadFirstDesignPatterns;

public abstract class Duck
{
    internal IFlyable _flyBehavior;
    internal IQuackable _quackBehavior;
    public Duck() { }
    
    public virtual void Quack()
    {
        Console.WriteLine("Quack");
    }

    public void Swim()
    {
        Console.WriteLine("Swimming...");
    }

    public abstract void Display();

    public void PerformQuack()
    {
        _quackBehavior.Quack();
    }

    public void PerformFly()
    {
        _flyBehavior.Fly();
    }
}


public class MallardDuck : Duck
{
    public MallardDuck()
    {
        _flyBehavior = new FlyWithWings();
        _quackBehavior = new RegularQuack();
    }
    
    public override void Display()
    {
        Console.WriteLine("I'm a Mallard Duck!");
    }
}

public class RedheadDuck : Duck
{
    public RedheadDuck()
    {
        _flyBehavior = new FlyWithWings();
        _quackBehavior = new RegularQuack();
    }
    public override void Display()
    {
        Console.WriteLine("I'm a Redhead Duck!");
    }
}

public class RubberDuck : Duck, IQuackable
{
    public RubberDuck()
    {
        _flyBehavior = new FlyNoWay();
        _quackBehavior = new Squeak();
    }
    public override void Display()
    {
        Console.WriteLine("I'm a Rubber Duck");
    }
}