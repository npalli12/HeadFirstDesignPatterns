```mermaid
classDiagram
ISubject <|--WeatherData
IDisplayElement <|-- CurrentConditionsDisplay
IDisplayElement <|-- StatisticsDisplay
IDisplayElement <|-- ForecastDisplay
IDisplayElement <|-- ThirdPartyDisplay 
IObserver <|-- CurrentConditionsDisplay
IObserver <|-- StatisticsDisplay
IObserver <|-- ForecastDisplay
IObserver <|-- ThirdPartyDisplay 

class ISubject
<<interface>> ISubject
ISubject : RegisterObserver()
ISubject : RemoveObserver()
ISubject : NotifyObserver()

class WeatherData
WeatherData : RegisterObserver()
WeatherData : RemoveObserver()
WeatherData : NotifyObserver()
WeatherData : GetTemperature()
WeatherData : GetHumidity)
WeatherData : GetPressure()

class IObserver
<<interface>> IObserver
IObserver : Update()

class IDisplayElement
<<interface>> IDisplayElement
IDisplayElement : Display()

class CurrentConditionsDisplay
CurrentConditionsDisplay : Update()
CurrentConditionsDisplay : Display()

class StatisticsDisplay
StatisticsDisplay : Update()
StatisticsDisplay : Display()

class ForecastDisplay
ForecastDisplay : Update()
ForecastDisplay : Display()

class ThirdPartyDisplay 
ThirdPartyDisplay : Update()
ThirdPartyDisplay : Display()
```
