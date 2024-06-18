using SampleAPI_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.ServicesContracts
{
    public interface IBoardService<T>
    {
        public  Task<int> insertBoard(T Board);

        public Task<T> getSingleBoard(int BoardId);

        public Task<List<T>> getAllBoard();


        // not adding update and delete functionality


    }
}
