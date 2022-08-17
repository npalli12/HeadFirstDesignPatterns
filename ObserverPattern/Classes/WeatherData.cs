using System.Collections.Generic;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Classes;

public class WeatherData : ISubject
{

    public List<IObserver> Observers;
    private float _temperature;
    private float _humidity;
    private float _pressure;

    public WeatherData()
    {
        Observers = new();
    }

    public void RegisterObserver(IObserver o)
    {
        Observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        Observers.Remove(o);
    }

    public void NotifyObservers()
    {
        foreach (var observer in Observers)
        {
            observer.Update();
        }
    }

    public float GetTemperature() => _temperature;
    public float GetHumidity() => _humidity;
    public float GetPressure() => _pressure;
    
    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void SetMeasurements(float temp, float humidity, float pressure)
    {
        _temperature = temp;
        _humidity = humidity;
        _pressure = pressure;
        MeasurementsChanged();
    }
}