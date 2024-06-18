using ApplicationLayer.ServicesContracts;
using SampleAPI_Core.Entities;
using SampleAPI_Core.RepostioryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.ServiceClass
{
    public class WeatherService: IWeatherService<Weather>
    {
        IWeatherRepository<Weather> weatherRepository;
        public WeatherService(IWeatherRepository<Weather> _weatherRepository)
        {
            this.weatherRepository = _weatherRepository;
        }

        public async Task<int> insertWeather(Weather Weather)
        {
            return await this.weatherRepository.insertWeather(Weather);
        }

        public async Task<Weather> getSingleWeather(int WeatherId)
        {
            return await this.weatherRepository.getSingleWeather(WeatherId);

        }

        public async Task<List<Weather>> getAllWeather()
        {
            return await this.weatherRepository.getAllWeather();
        }
    }
}
