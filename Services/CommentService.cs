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
        public async void Create(Comment comment, int postId, BoardPost selectedpost)
        {

            var post = _context.Posts.Where(x => x.Id == postId).FirstOrDefault();
            var newcomment = new Comment { Author=comment.Author, PubDate=comment.PubDate, Body=comment.Body, Boardpost=selectedpost };

            post.Comments.Add(newcomment); 
            await _context.SaveChangesAsync();
            

        }

        public async Task<bool> Delete(int Id)
        {
            var comment = await _context.Comments.Where(x => x.Id == Id).FirstOrDefaultAsync();
            _context.Comments.Remove(comment);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<List<Comment>> ListAllComments(string postId)
        {
            int.TryParse(postId, out var list);
            var comments = await _context.Comments.Where(x=>x.Boardpost.Id ==  list).ToListAsync();
            comments.Reverse();
            return comments;
        }
    }
}
