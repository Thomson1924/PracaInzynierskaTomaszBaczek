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
        public async void Create(BoardPost boardpost)
        {
            await _context.Posts.AddAsync(boardpost);
            await _context.SaveChangesAsync();
        }

        public async void Delete(int Id)
        {
            var post = _context.Posts.Where(x => x.Id == Id).FirstOrDefault();
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
        }
        public async Task<List<BoardPost>> ListAll()
        {
            return await _context.Posts.ToListAsync();
        }
    }
}
