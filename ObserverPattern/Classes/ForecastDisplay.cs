using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Classes;

public class ForecastDisplay : IObserver, IDisplayElement
{

    private WeatherData _weatherData;
    private float _currentPressure = 29.9f;
    private float _lastPressure;

    public ForecastDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        var updatedPressure = _weatherData.GetPressure();

        _lastPressure = _currentPressure;
        _currentPressure = updatedPressure;
    }

    public string Display()
    {
        var displayString = $"last: {_lastPressure} current: {_currentPressure}";
        return displayString;
    }
}