using System;

namespace StrategyPattern;

public class RegularQuack : IQuackable
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }
}