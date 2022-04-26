using Microsoft.EntityFrameworkCore;
using PracaInżynierskaTomaszBaczek.Data;
using PracaInżynierskaTomaszBaczek.Interfaces;
using PracaInżynierskaTomaszBaczek.Models;
using PracaInżynierskaTomaszBaczek.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInżynierskaTomaszBaczek.Services
{
    public class HillViewerService : IHillViewerService
    {
        private readonly ApplicationDbContext _context;
        public HillViewerService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddHill(string Author, string HillName, Guid FileId)
        {
            var user = await _context.Users.Where(x => x.UserName== Author).FirstOrDefaultAsync();
            if (user==null)
            {
                return false;
            }
            var data = new CreatedHills 
            { 
                guid = FileId,
                HillName=HillName,
                User = user
            };
            await _context.Hills.AddAsync(data);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }
        public async Task<bool> AddHill(string HillName, Guid FileId)
        {
            var data = new CreatedHills
            {
                guid = FileId,
                HillName = HillName
            };
            await _context.Hills.AddAsync(data);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }


        public async Task<List<CreatedHills>> ListAll()
        {
            var hills = await _context.Hills.ToListAsync();
            return hills;
        }
    }
}
