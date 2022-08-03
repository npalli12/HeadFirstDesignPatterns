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
    public void TestMallardDuck()
    {
        var mallardDuck = new MallardDuck();
        
        mallardDuck.Display();
        mallardDuck.PerformQuack();
        mallardDuck.PerformFly();
        
        Assert.Pass();
    }
    
    
    [Test]
    public void TestRubberDuck()
    {
        var rubberDuck = new RubberDuck();
        
        rubberDuck.Display();
        rubberDuck.PerformQuack();
        rubberDuck.PerformFly();
        
        Assert.Pass();
    }
}