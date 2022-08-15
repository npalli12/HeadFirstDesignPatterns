using System;

namespace StrategyPattern;

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