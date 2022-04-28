using PracaInżynierskaTomaszBaczek.Migrations;
using PracaInżynierskaTomaszBaczek.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracaInżynierskaTomaszBaczek.Interfaces
{
    public interface IHillViewerService
    {
        Task<bool> AddHill(string Author, string HillName, Guid FileId);
        Task<bool> AddHill(string HillName, Guid FileId);
        Task<List<CreatedHills>> ListAll();
        Task<List<CreatedHills>> ListAll(string userId);
        void DeleteHill(int Id);
    }
}
