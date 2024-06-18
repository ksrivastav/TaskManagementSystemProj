using ApplicationLayer.ServicesContracts;
using Microsoft.AspNetCore.Mvc;
using SampleAPI_Core.Entities;

namespace SampleProject_API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TaskManagementController : Controller
    {
        ITaskService<SampleAPI_Core.Entities.Tasks> TaskSerivce;
        IBoardService<Board> BoardService;
        public TaskManagementController(ITaskService<SampleAPI_Core.Entities.Tasks> _TaskSerivce, IBoardService<Board> _BoardService)
        {
            this.TaskSerivce = _TaskSerivce;

            this.BoardService = _BoardService;


        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //get
        // /cities
        // /cities/{id}


        [HttpGet(Name = "Boards")]
        public async Task<IActionResult> getBoards()
        {
            var result = await this.BoardService.getAllBoard();
            return Ok(result);

        }

        [HttpGet(Name = "Tasks")]
        public async Task<IActionResult> getTasks()
        {
            var result = await this.TaskSerivce.getAllTask();

            return Ok(result);

        }

        [HttpPost(Name = "NewTask")]
        public async Task<IActionResult> newTasks(Tasks task)
        {
            var result = await this.TaskSerivce.insertTask(task);

            return Ok(result);

        }

        [HttpGet(Name = "Tasks-search")]
        public async Task<IActionResult> getSingleTasks(int id)
        {
            var result = await this.TaskSerivce.getSingleTask(id);

            return Ok(result);

        }

        [HttpPost(Name = "NewBoard")]
        public async Task<IActionResult> newBoards(Board board)
        {
            var result = await this.BoardService.insertBoard(board);

            return Ok(result);

        }

        [HttpGet(Name = "Boards-search")]
        public async Task<IActionResult> getSingleBoard(int id)
        {
            var result = await this.BoardService.getSingleBoard(id);

            return Ok(result);

        }



    }
}
