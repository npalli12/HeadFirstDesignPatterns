using System;

namespace HeadFirstDesignPatterns;

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