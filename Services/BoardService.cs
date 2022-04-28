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
    public class BoardService : IBoardpostService
    {
        private readonly ApplicationDbContext _context;
        public BoardService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Create(BoardPost boardpost)
        {
            await _context.Posts.AddAsync(boardpost);
            await _context.SaveChangesAsync();
        }

        public async void Delete(int Id)
        {
            var post = await _context.Posts.Where(x => x.Id == Id).FirstOrDefaultAsync();
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
        }
        public async Task<List<BoardPost>> ListAll()
        {
            
            var post = await _context.Posts.ToListAsync();
            post.Reverse();
            return post;
        }

        public async Task<List<BoardPost>> ListAll(string author)
        {

            var posts = await _context.Posts.Where(x => x.Author == author).ToListAsync();
            posts.Reverse();
            return posts;
        }

        public async Task<BoardPost> GetPost(string Id)
        {
            int.TryParse(Id, out var postId);
            return await _context.Posts
                .Include(y => y.Comments)
                .Where(x => x.Id == postId)
                .FirstOrDefaultAsync();
        }
    }
}
