using System;

namespace HeadFirstDesignPatterns;

public class Squeak : IQuackable
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}