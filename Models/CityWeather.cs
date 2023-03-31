namespace Models
{
    public class CityWeather
    {
        public string? CityUniqueCode { get; set; }
        public string? CityName { get; set; }

        public DateTime DateAndTime { get; set; }

        public int TemperatureFahrenheit { get; set; }

        public string HoursAmPm => DateAndTime.ToString("HH:mm tt");

        public string BackgroundColorByTemperature => TemperatureFahrenheit > 74 ? "green-back" :
                                                      TemperatureFahrenheit < 44 ? "blue-back" : "orange-back";
    }
}