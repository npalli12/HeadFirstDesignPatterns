using System;

namespace StrategyPattern;

public class Squeak : IQuackable
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}