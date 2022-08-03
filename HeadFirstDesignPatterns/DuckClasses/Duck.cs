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

    public void SetFlyBehavior(IFlyable fb)
    {
        _flyBehavior = fb;
    }

    public void SetQuackBehavior(IQuackable qb)
    {
        _quackBehavior = qb;
    }
}




