using System;

namespace StrategyPattern;

public class FlyNoWay : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Not Flying");
    }
}