using System;

namespace StrategyPattern;

public class FlyWithWings : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("I'm Flying!!");
    }
}