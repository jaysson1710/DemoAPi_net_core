using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository;

namespace DemoAPi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       

        private readonly ILogger<WeatherForecastController> _logger;

        public IRepositorioWeather RepositorioWeather { get; private set; }

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IRepositorioWeather repositorioWeather)
        {
            _logger = logger;
            RepositorioWeather = repositorioWeather;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            return await RepositorioWeather.GetList();
        }

        [HttpGet("{id}")]
        public async Task<WeatherForecast> GetItem(int id)
        {

            var rng = new Random();
            return await RepositorioWeather.GetItem(id);
        }

        [HttpGet("[action]")]
        public async Task<WeatherForecast> GetAlgo(int id)
        {
            return await RepositorioWeather.GetItem(id);
        }
    }
}
