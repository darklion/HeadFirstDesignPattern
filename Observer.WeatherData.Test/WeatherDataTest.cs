using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Observer.WeatherData.Test
{
    [TestClass]
    public class WeatherDataTest
    { 
        [TestMethod]
        public void UpdateAllDisplayTest()
        {
            var weatherData = new WeatherData();
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            var forecastDisplay = new ForecastDisplay(weatherData);
            var statisticsDisplay = new StatisticsDisplay(weatherData);
            var heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f); 
        }

        [TestMethod]
        public void SetMeasurements_Should_Call_Displays_Update_Method()
        {
            var weatherData = new WeatherData();
            var mockCurrentConditionsDisplay = new Mock<CurrentConditionsDisplay>();
            mockCurrentConditionsDisplay.Setup(p => p.Update(80, 65, 30.4f));
            weatherData.SetMeasurements(80, 65, 30.4f); 
             
        }
    }
}
