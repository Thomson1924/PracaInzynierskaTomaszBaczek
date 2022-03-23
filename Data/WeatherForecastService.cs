using PracaInżynierskaTomaszBaczek.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInżynierskaTomaszBaczek.Data
{
    public class WeatherForecastService
    {
        public IHillService HillService;
        public WeatherForecastService(IHillService hs)
        {
            HillService = hs;
        }



        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            HillService.CreateHill(new Models.UserInputModel { CountryCode = "POL", HillName="TEST", HillSize = 100 });
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }

}
