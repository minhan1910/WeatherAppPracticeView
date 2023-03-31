using ServiceContracts;
using Models;

namespace Services
{
    public class WeatherService : IWeatherService
    {
        private readonly List<CityWeather> citiesWeather = new()
            {
                new CityWeather()
                {
                        CityUniqueCode = "LDN",
                        CityName = "London",
                        DateAndTime = new DateTime(2030, 1, 1, 8, 0, 0),
                        TemperatureFahrenheit = 33
                },
                new CityWeather()
                {
                        CityUniqueCode = "NYC",
                        CityName = "New York",
                        DateAndTime = new DateTime(2030, 1, 1, 3, 0, 0),
                        TemperatureFahrenheit = 60
                },
                new CityWeather()
                {
                        CityUniqueCode = "PAR",
                        CityName = "Paris",
                        DateAndTime = new DateTime(2030, 1, 1, 9, 0, 0),
                        TemperatureFahrenheit = 82
                }
            };

        public CityWeather? GetWeatherByCityCode(string cityCode)
        {
            return citiesWeather
                .Where(city => city.CityUniqueCode is not null && 
                                city.CityUniqueCode.Equals(cityCode))
                    .FirstOrDefault();
        }

        public List<CityWeather> GetWeatherDetails()
        {
            return citiesWeather;
        }
    }
}