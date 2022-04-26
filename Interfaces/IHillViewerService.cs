using PracaInżynierskaTomaszBaczek.Migrations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracaInżynierskaTomaszBaczek.Interfaces
{
    public interface IHillViewerService
    {
        Task<bool> AddHill(string Author, string HillName, Guid FileId);
        Task<bool> AddHill(string HillName, Guid FileId);
        Task<List<Models.CreatedHills>> ListAll();
    }
}
