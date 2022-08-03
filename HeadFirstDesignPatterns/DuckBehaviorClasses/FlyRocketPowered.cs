﻿using System;

namespace HeadFirstDesignPatterns;

public class FlyRocketPowered : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("I'm Flying with a Rocket!");
    }
}