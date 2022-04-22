using System;
using System.Collections.Generic;
using System.Linq;
using PracaInżynierskaTomaszBaczek.Models;
using System.Threading.Tasks;

namespace PracaInżynierskaTomaszBaczek.Interfaces
{
    interface IBoardpostService
    {
        public void Create(BoardPost boardpost);
        public void Delete(int Id);
        public Task<List<BoardPost>> ListAll();
    }
}
