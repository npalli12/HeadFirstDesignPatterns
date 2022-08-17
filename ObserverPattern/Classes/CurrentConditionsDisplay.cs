using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Classes;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float _temperature;
    private float _humidity;
    private WeatherData _weatherData;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }
    public void Update(float temp, float humidity, float pressure)
    {
        _temperature = temp;
        _humidity = humidity;
        Display();
    }

    public string Display()
    {
        var displayStr = $"Current Conditions : {_temperature}F degrees and {_humidity}% humidity";
        return displayStr;
    }
}