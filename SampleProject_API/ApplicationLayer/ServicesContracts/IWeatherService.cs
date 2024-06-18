using SampleAPI_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.ServicesContracts
{
    public interface IWeatherService<T>
    {
        public Task<int> insertWeather(T Weather);

        public Task<T> getSingleWeather(int WeatherId);

        public Task<List<T>> getAllWeather();
    }
}
