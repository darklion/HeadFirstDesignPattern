using System;
using System.Collections.Generic;

namespace Observer.WeatherData
{
    public class WeatherData : ISubject
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        private List<IObserver> _observers;

        public WeatherData()
        {
            _temperature = 0;
            _humidity = 0;
            _pressure = 0;
            this._observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObserver()
        {
            foreach (var subscriber in _observers)
            {
                subscriber.Update(_temperature, _humidity, _pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            MeasurementsChanged();
        }
    }

    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver();
    }


    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }

    public interface IDisplayElement
    {
        void Display();
    }

    public class   StatisticsDisplay: IObserver, IDisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum= 0.0f;
        private int numReadings;
        private WeatherData _weatherData;

        public StatisticsDisplay(WeatherData weatherData) {
            this._weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            tempSum += temperature;
            numReadings++;

            if (temperature > maxTemp) {
                maxTemp = temperature;
            }
 
            if (temperature < minTemp) {
                minTemp = temperature;
            }

            Display();

            Console.WriteLine($"temperature : { temperature}, humidity : { humidity}, pressure : { pressure}");
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {(tempSum / numReadings)}/{maxTemp}/{minTemp}");
        }
    }

    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private WeatherData _weatherData;

        public ForecastDisplay(WeatherData weatherData) {
            this._weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Forecast: ");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (currentPressure < lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }
    }

    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private readonly ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature} F degrees and {_humidity} % humidity");
        }
    }

    public class HeatIndexDisplay : IObserver, IDisplayElement
    { 
        float _heatIndex = 0.0f;
        private readonly WeatherData _weatherData;

        public HeatIndexDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _heatIndex = ComputeHeatIndex(temperature, humidity);
            Display();
        }

        private float ComputeHeatIndex(float t, float rh) {
            float index = (float)((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh) 
                                   + (0.00941695 * (t * t)) + (0.00728898 * (rh * rh)) 
                                   + (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
                                   (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 * 
                                                                                                       (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) + 
                                   (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
                                   0.000000000843296 * (t * t * rh * rh * rh)) -
                                  (0.0000000000481975 * (t * t * t * rh * rh * rh)));
            return index;
        }

        public void Display()
        {
            Console.WriteLine($"Heat index is {_heatIndex}");
        }
    }
}
