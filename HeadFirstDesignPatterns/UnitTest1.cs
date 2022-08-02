using System;
using NUnit.Framework;

namespace HeadFirstDesignPatterns;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        new MallardDuck().Display();
        new RedheadDuck().Display();
        var rubberDuck = new RubberDuck();
        
        rubberDuck.Display();
        rubberDuck.Quack();
        rubberDuck.Fly();
        Assert.Pass();
    }
}