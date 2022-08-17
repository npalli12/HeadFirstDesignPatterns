using System.Collections.Generic;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Classes;

public class WeatherData : ISubject
{

    public List<IObserver> Observers;
    private float _temerature;
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
            observer.Update(_temerature, _humidity, _pressure);
        }
    }
    
    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void SetMeasurements(float temp, float humidity, float pressure)
    {
        _temerature = temp;
        _humidity = humidity;
        _pressure = pressure;
        MeasurementsChanged();
    }
}