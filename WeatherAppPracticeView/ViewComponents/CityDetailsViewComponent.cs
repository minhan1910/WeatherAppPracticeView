using Microsoft.AspNetCore.Mvc;
using WeatherAppPracticeView.Models;
using Models;

namespace WeatherAppPracticeView.ViewComponents
{
    public class CityDetailsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(CityWeather cityWeather, int? isDetailsPage)
        {
            return View("CityDetails", new CityDetailsWrapperModel() { 
                CityWeather = cityWeather, 
                isDetailsPage = isDetailsPage ?? 0 
            });
        }
    }
}
