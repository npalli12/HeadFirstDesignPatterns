using System;

namespace HeadFirstDesignPatterns;

public class FlyWithWings : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("I'm Flying!!");
    }
}