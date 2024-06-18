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
    public class CityService: ICitySerivce<City>
    {
        ICityRepository<City> cityRepository;
        public CityService(ICityRepository<City> _cityRepository)
        {
            this.cityRepository = _cityRepository;

        }
        public async Task<int> insertCity(City city)
        {
            return await this.cityRepository.insertCity(city);
        }

        public async Task<City> getSingleCity(int cityId)
        {
            return await this.cityRepository.getSingleCity(cityId);
        }

        public async Task<List<City>> getAllCity()
        {
            return await this.cityRepository.getAllCity();
        }
    }
}
