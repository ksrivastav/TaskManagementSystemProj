using SampleAPI_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAPI_Core.RepostioryContracts
{
    public interface ICityRepository<T>
    {
        public Task<int> insertCity(T city);

        public Task<T> getSingleCity(int cityId);
        
        public Task<List<T>> getAllCity();


        // not adding update and delete functionality


    }
}
