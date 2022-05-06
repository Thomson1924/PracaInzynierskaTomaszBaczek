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
            var data = new CreatedHill 
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
            var data = new CreatedHill
            {
                guid = FileId,
                HillName = HillName
            };
            await _context.Hills.AddAsync(data);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }


        public async Task<List<CreatedHill>> ListAll()
        {
            var hills = await _context.Hills
                .Include(y => y.User)
                .ToListAsync();
            hills.Reverse();
            return hills;
        }

        public async Task<List<CreatedHill>> ListAll(string userID)
        {
            var hills = await _context.Hills.Where(x=>x.User.UserName == userID).ToListAsync();
            hills.Reverse();
            return hills;
        }

        public async void DeleteHill(int Id)
        {
            var hill = await _context.Hills.Where(x => x.Id == Id).FirstOrDefaultAsync();
            _context.Hills.Remove(hill);
            await _context.SaveChangesAsync();
        }

        public async Task<CreatedHill> GetHillByGuid(string Id)
        {
            Guid.TryParse(Id, out var hill);
            return await _context.Hills.Where(x => x.guid == hill).FirstOrDefaultAsync();
        }
    }
}
