using System.ComponentModel.DataAnnotations;

namespace WeatherForecastWASM.Data
{
    public class WeatherConfiguration
    {
        [Required]
        public string ApiKey { get; set; }

        [Required]
        public Uri Url { get; set; } = new("https://api.weatherapi.com/v1/");
    }
}
