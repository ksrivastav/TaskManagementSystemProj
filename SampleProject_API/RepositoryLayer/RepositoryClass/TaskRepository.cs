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
    public class TaskRepository: ITaskRepository<SampleAPI_Core.Entities.Tasks>
    {
        SampleApi_DBContext dbContext;
        public TaskRepository(SampleApi_DBContext _dBContext)
        {
            this.dbContext = _dBContext;
        }
        public async Task<int> insertTask(SampleAPI_Core.Entities.Tasks Task)
        {
            await this.dbContext.Task.AddAsync(Task);
            var result = await this.dbContext.SaveChangesAsync();
            return result;
        }

        public async Task<SampleAPI_Core.Entities.Tasks> getSingleTask(int TaskId)
        {
            return new SampleAPI_Core.Entities.Tasks
            {
                TaskId = 1,                
                TaskStatus = "New",
                Description = "Sprint 1 Task",
                DeadLine = System.DateTime.Now

        };

            //var result = await this.dbContext.Task.FirstAsync(x=> x.TaskId==TaskId);
            //return result;
        }

        public async Task<List<SampleAPI_Core.Entities.Tasks>> getAllTask()
        {
            //var result = await this.dbContext.Task.ToListAsync();
            //return result;

            return new List<SampleAPI_Core.Entities.Tasks> { new SampleAPI_Core.Entities.Tasks { TaskId = 1,
                TaskStatus = "New",
                Description = "Sprint 1 Task",                
                DeadLine = System.DateTime.Now} };
        }

    }
}
