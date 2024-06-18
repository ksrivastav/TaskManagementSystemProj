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
    public class TaskService: ITaskService<SampleAPI_Core.Entities.Tasks>
    {
        public readonly ITaskRepository<SampleAPI_Core.Entities.Tasks> TaskRepository;
        public TaskService(ITaskRepository<SampleAPI_Core.Entities.Tasks> _TaskRepository)
        {
            this.TaskRepository = _TaskRepository;

        }
        public async Task<int> insertTask(SampleAPI_Core.Entities.Tasks Task)
        {
            return await this.TaskRepository.insertTask(Task);
        }

        public async Task<SampleAPI_Core.Entities.Tasks> getSingleTask(int TaskId)
        {
            return await this.TaskRepository.getSingleTask(TaskId);
        }

        public async Task<List<SampleAPI_Core.Entities.Tasks>> getAllTask()
        {
            return await this.TaskRepository.getAllTask();
        }
    }
}
