using SampleAPI_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.ServicesContracts
{
    public interface ITaskService<T>
    {
        public  Task<int> insertTask(T Task);

        public Task<T> getSingleTask(int TaskId);

        public Task<List<T>> getAllTask();


        // not adding update and delete functionality


    }
}
