using System;
using System.Collections.Generic;
using System.Linq;
using PracaInżynierskaTomaszBaczek.Models;
using System.Threading.Tasks;

namespace PracaInżynierskaTomaszBaczek.Interfaces
{
    interface IBoardpostService
    {
        public Task Create(BoardPost boardpost);
        public Task<bool> Delete(int Id);
        public Task<List<BoardPost>> ListAll();
        public Task<List<BoardPost>> ListAll(string author);
        public Task<BoardPost> GetPost(string Id);
    }
}
