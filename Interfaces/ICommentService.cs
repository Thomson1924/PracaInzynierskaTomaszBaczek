using System;
using System.Collections.Generic;
using System.Linq;
using PracaInżynierskaTomaszBaczek.Models;
using System.Threading.Tasks;


namespace PracaInżynierskaTomaszBaczek.Interfaces
{
    public interface ICommentService
    {
        public void Create(Comment comment, int postId, BoardPost post);
        public void Delete(int Id);
        public Task<List<Comment>> ListAll();
    }
}
