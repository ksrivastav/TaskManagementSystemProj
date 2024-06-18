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
    public class BoardService: IBoardService<Board>
    {
        public readonly IBoardRepository<Board> BoardRepository;
        public BoardService(IBoardRepository<Board> _BoardRepository)
        {
            this.BoardRepository = _BoardRepository;

        }
        public async Task<int> insertBoard(Board Board)
        {
            return await this.BoardRepository.insertBoard(Board);
        }

        public async Task<Board> getSingleBoard(int BoardId)
        {
            return await this.BoardRepository.getSingleBoard(BoardId);
        }

        public async Task<List<Board>> getAllBoard()
        {
            return await this.BoardRepository.getAllBoard();
        }
    }
}
