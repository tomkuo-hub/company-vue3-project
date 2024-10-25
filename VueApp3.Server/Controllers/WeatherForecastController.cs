using Microsoft.AspNetCore.Mvc;

namespace VueApp3.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        //public IEnumerable<BDMT03> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

            //string connectionString = "Server=localhost\\SQLEXPRESS;Database=evote;User Id=sa;Password=1qaz@WSX;";

            //using var connection = new SqlConnection(connectionString);
            //var bdmt03s = connection.Query<BDMT03>("SELECT top 1 * FROM BDMT03");
            //return bdmt03s.ToArray<BDMT03>();
        }
    }
}
