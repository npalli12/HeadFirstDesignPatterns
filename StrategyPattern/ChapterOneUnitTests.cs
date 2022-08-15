using NUnit.Framework;
using StrategyPattern.DuckClasses;

namespace StrategyPattern;

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
        mallardDuck.Swim();
        
        Assert.Pass();
    }
    
    
    [Test]
    public void TestRubberDuck()
    {
        var rubberDuck = new RubberDuck();
        
        rubberDuck.Display();
        rubberDuck.PerformQuack();
        rubberDuck.PerformFly();
        rubberDuck.Swim();
        
        Assert.Pass();
    }
    
      
    [Test]
    public void TestRedheadDuck()
    {
        var redheadDuck = new RedheadDuck();
        
        redheadDuck.Display();
        redheadDuck.PerformQuack();
        redheadDuck.PerformFly();
        redheadDuck.Swim();
        
        Assert.Pass();
    }

    [Test]
    public void MiniDuckSimulator()
    {
        var mallardDuck = new MallardDuck();
        mallardDuck.Display();
        mallardDuck.PerformQuack();
        mallardDuck.PerformFly();

        var modelDuck = new ModelDuck();
        modelDuck.Display();
        modelDuck.PerformQuack();
        modelDuck.PerformFly();
        modelDuck.SetFlyBehavior(new FlyRocketPowered());
        modelDuck.PerformFly();
    }
}