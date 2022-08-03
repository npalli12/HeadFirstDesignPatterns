using System;

namespace HeadFirstDesignPatterns;

public class FlyNoWay : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Not Flying");
    }
}