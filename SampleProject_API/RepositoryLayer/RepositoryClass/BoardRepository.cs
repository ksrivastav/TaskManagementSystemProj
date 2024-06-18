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
    public class BoardRepository: IBoardRepository<Board>
    {
        SampleApi_DBContext dbContext;
        public BoardRepository(SampleApi_DBContext _dBContext)
        {
            this.dbContext = _dBContext;
        }
        public async Task<int> insertBoard(Board Board)
        {
            await this.dbContext.Board.AddAsync(Board);
            var result = await this.dbContext.SaveChangesAsync();
            return result;
        }

        public async Task<Board> getSingleBoard(int BoardId)
        {
            return new Board
            {
                BoardId = 1,                
                BoardStatus = "New",
                Description = "Sprint 1 Board",
                Title = "Sprint 1 Board",
                DeadLine = System.DateTime.Now

        };

            //var result = await this.dbContext.Board.FirstAsync(x=> x.BoardId==BoardId);
            //return result;
        }

        public async Task<List<Board>> getAllBoard()
        {
            //var result = await this.dbContext.Board.ToListAsync();
            //return result;

            return new List<Board> { new Board { BoardId = 1,
                BoardStatus = "New",
                Description = "Sprint 1 Board",
                Title = "Sprint 1 Board",
                DeadLine = System.DateTime.Now} };
        }

    }
}
