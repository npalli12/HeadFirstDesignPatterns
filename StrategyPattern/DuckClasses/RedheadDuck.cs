using System;

namespace StrategyPattern;

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

