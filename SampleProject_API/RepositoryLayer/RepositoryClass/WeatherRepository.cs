using DAL;
using SampleAPI_Core.Entities;
using SampleAPI_Core.RepostioryContracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.RepositoryClass
{
    public class WeatherRepository: IWeatherRepository<Weather>
    {
        SampleApi_DBContext dbContext;
        public WeatherRepository(SampleApi_DBContext _dBContext)
        {
            this.dbContext = _dBContext;
        }
        public async Task<int> insertWeather(Weather Weather)
        {
            await this.dbContext.Weather.AddAsync(Weather);
            var result = await this.dbContext.SaveChangesAsync();
            return result;
        }

        public async Task<Weather> getSingleWeather(int WeatherId)
        {

            return new Weather { WeatherId = 1, Temprature = 32, TempratureUnit="Degree" ,  City= new City {CityId=1, CityCode="DEL", Name="New Delhi", State="New Delhi", Country="India" } };

            //var result = await this.dbContext.Weather.FirstAsync(x => x.WeatherId == WeatherId);
            //return result;
        }

        public async Task<List<Weather>> getAllWeather()
        {
            return new List<Weather> { new Weather { WeatherId = 1, Temprature = 32, TempratureUnit = "Degree", DateTime = DateTime.Now, City = new City { CityId = 1, CityCode = "DEL", Name = "New Delhi", State = "New Delhi", Country = "India" } } };

            var result = await this.dbContext.Weather.ToListAsync();
            return result;
        }
    }
}
