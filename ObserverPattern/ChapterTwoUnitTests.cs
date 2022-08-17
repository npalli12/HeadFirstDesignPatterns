using System;
using NUnit.Framework;
using ObserverPattern.Classes;

namespace ObserverPattern;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestCurrentConditionsDisplay()
    {
        //Arrange
        var weatherData = new WeatherData();
        var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
        weatherData.SetMeasurements(72, 80, 30);

        //Act
        var resultDisplayString = currentConditionsDisplay.Display();
        
        //Assert
        var expectedDisplayString = $"Current Conditions : {72}F degrees and {80}% humidity";
        Assert.That(resultDisplayString, Is.EqualTo(expectedDisplayString));
    }
}