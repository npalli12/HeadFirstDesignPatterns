using System;

namespace HeadFirstDesignPatterns;

public class RegularQuack : IQuackable
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }
}