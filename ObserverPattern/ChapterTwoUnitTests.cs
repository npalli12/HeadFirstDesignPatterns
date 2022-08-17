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
    
    [Test]
    public void TestStatisticsDisplay()
    {
        //Arrange
        var weatherData = new WeatherData();
        var statDisplay = new StatisticsDisplay(weatherData);
        weatherData.SetMeasurements(70, 80, 30);
        weatherData.SetMeasurements(71, 80, 30);
        weatherData.SetMeasurements(72, 80, 30);

        //Act
        var resultDisplayString = statDisplay.Display();
        
        //Assert
        var expectedDisplayString = $"min: {70}, max: {72}, avg: {71}";
        Assert.That(resultDisplayString, Is.EqualTo(expectedDisplayString));
    }
    
    [Test]
    [TestCase(29.9f)]
    [TestCase(30f)]
    [TestCase(29f)]
    public void TestForecastDisplay(float expected)
    {
        //Arrange
        var weatherData = new WeatherData();
        var statDisplay = new ForecastDisplay(weatherData);
        weatherData.SetMeasurements(70, 80, expected);

        //Act
        var resultDisplayString = statDisplay.Display();
        
        //Assert
        var expectedDisplayString = $"last: {29.9} current: {expected}";
        Assert.That(resultDisplayString, Is.EqualTo(expectedDisplayString));
    }
}