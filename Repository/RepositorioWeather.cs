using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Repository.Data;

namespace Repository
{
    public class RepositorioWeather : IRepositorioWeather
    {
        public RepositorioWeather(WeatherDbContext context)
        {
            Context = context;
        }

        public WeatherDbContext Context { get; }

        public async Task<List<WeatherForecast>> GetList()
        {
            var list = await this.Context.WeatherForecast.AsNoTracking().ToListAsync();
            return list;
        }

        public async Task<WeatherForecast> GetItem(int id)
        {
            var list = await this.Context.WeatherForecast.AsNoTracking().ToListAsync();

            return list.ToList().Where(x=> x.Id == id).FirstOrDefault();
        }
    }
}
