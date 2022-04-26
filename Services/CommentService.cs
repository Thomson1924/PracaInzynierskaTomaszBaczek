using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracaInżynierskaTomaszBaczek.Data;
using PracaInżynierskaTomaszBaczek.Interfaces;
using PracaInżynierskaTomaszBaczek.Models;

namespace PracaInżynierskaTomaszBaczek.Services
{
    public class CommentService : ICommentService
    {
        private readonly ApplicationDbContext _context;
        public CommentService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async void Create(Comment comment, int postId, BoardPost post)
        {
            comment.Boardpost = post;
            comment.Boardpost.Id = postId; 
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();

        }

        public async void Delete(int Id)
        {
            var comment = await _context.Comments.Where(x => x.Id == Id).FirstOrDefaultAsync();
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
        }

        public Task<List<Comment>> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}
