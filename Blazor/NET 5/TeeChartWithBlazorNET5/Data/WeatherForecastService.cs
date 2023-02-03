using System;
using System.Linq;
using System.Threading.Tasks;

namespace TeeChartOnBlazor.Data
{
	public class WeatherForecastService
	{
		public static readonly string[] Summaries = new[]
		{
						"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		public static readonly int[] temps = new[]
		{
				54,28,54,15,23,74	 //using fixed, common temp source
		};

		public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
		{
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
