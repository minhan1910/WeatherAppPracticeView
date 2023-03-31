using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using Models;

namespace WeatherAppPracticeView.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherService _weatherService;

        public HomeController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [Route("/")]
        public IActionResult Index()
        {
            List<CityWeather> citiesWeather = _weatherService.GetWeatherDetails();

            return View(citiesWeather);
        }

        [Route("/weather/{cityCode}")]
        public IActionResult Details([FromRoute] string? cityCode)
        {
            if (string.IsNullOrEmpty(cityCode))
            {
                return View("InvalidCityCode");
            }

            CityWeather? cityWeather = _weatherService.GetWeatherByCityCode(cityCode);

            if (cityWeather is null)
            {
                return View("InvalidCityCode");
            }

            return View(cityWeather);
        }
    }
}
