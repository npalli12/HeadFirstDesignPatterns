namespace ObserverPattern.ClassesAndInterfaces;

public interface ISubject
{
    void RegisterObserver();
    void RemoveObserver();
    void NotifyObservers();
}