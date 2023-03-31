using Microsoft.AspNetCore.Mvc;
using WeatherAppPracticeView.Models;

namespace WeatherAppPracticeView.ViewComponents
{
    public class CityDetailsViewComponent : ViewComponent
    {
        private static readonly List<CityWeather> CitiesWeather = new()
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

        public async Task<IViewComponentResult> InvokeAsync(string cityCode, int isDetailsPage)
        {
            CityWeather? cityWeather =
                CitiesWeather.Where(city => string.Compare(city.CityUniqueCode, cityCode) == 0)
                             .FirstOrDefault();

            return View("CityDetails", new CityDetailsWrapperModel() { CityWeather = cityWeather, isDetailsPage = isDetailsPage });
        }
    }
}
