using System;
using System.Threading.Tasks;

namespace PracaInżynierskaTomaszBaczek.Interfaces
{
    public interface IDatabaseService
    {
        Task<bool> AddHill(string Author, string HillName, Guid FileId);
        Task<bool> AddHill(string HillName, Guid FileId);
    }
}
