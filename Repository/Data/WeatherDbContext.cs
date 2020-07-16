using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Repository.Data
{
    public class WeatherDbContext : DbContext
    {
        public WeatherDbContext(DbContextOptions<WeatherDbContext> options) : base(options)
        {
        }

        public DbSet<WeatherForecast> WeatherForecast { get; set; }
    }
}
