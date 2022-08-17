using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Classes;

public class StatisticsDisplay: IObserver, IDisplayElement
{
    private WeatherData _weatherData;
    private float _averageTemperature;
    private float _minTemperature = float.MaxValue;
    private float _maxTemperature = float.MinValue;
    private float _numOfUpdatesReceived;

    public StatisticsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }
    public void Update()
    {
        var updatedTemp = _weatherData.GetTemperature();
        if (updatedTemp > _maxTemperature)
        {
            _maxTemperature = updatedTemp;
        }

        if (updatedTemp < _minTemperature)
        {
            _minTemperature = updatedTemp;
        }

        _averageTemperature = 
            (_averageTemperature * _numOfUpdatesReceived + updatedTemp) 
                              / ++_numOfUpdatesReceived ;
    }

    public string Display()
    {
        return $"min: {_minTemperature}, max: {_maxTemperature}, avg: {_averageTemperature}";
    }
}