using Models;

namespace ServiceContracts
{
    public interface IWeatherService
    {
        public List<CityWeather> GetWeatherDetails();
        public CityWeather? GetWeatherByCityCode(string cityCode);
    }
}