﻿using System;

namespace HeadFirstDesignPatterns;

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        _flyBehavior = new FlyNoWay();
        _quackBehavior = new RegularQuack();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a Model Duck.");
    }
}
