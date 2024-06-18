using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleAPI_Core.Entities;
using SampleAPI_Core.RepostioryContracts;
using DAL;
using System.Data.Entity;

namespace RepositoryLayer.RepositoryClass
{
    public class CityRepository: ICityRepository<City>
    {
        SampleApi_DBContext dbContext;
        public CityRepository(SampleApi_DBContext _dBContext)
        {
            this.dbContext = _dBContext;
        }
        public async Task<int> insertCity(City city)
        {
            await this.dbContext.City.AddAsync(city);
            var result = await this.dbContext.SaveChangesAsync();
            return result;
        }

        public async Task<City> getSingleCity(int cityId)
        {
            return new City
            {
                CityId = 1,
                CityCode = "DEL",
                Name = "New Delhi",
                State = "New Delhi",
                Country = "India"
            };

            //var result = await this.dbContext.City.FirstAsync(x=> x.CityId==cityId);
            //return result;
        }

        public async Task<List<City>> getAllCity()
        {
            //var result = await this.dbContext.City.ToListAsync();
            //return result;

            return new List<City> { new City { CityId = 1, CityCode = "DEL", Name = "New Delhi", State = "New Delhi", Country = "India" } };
        }

    }
}
