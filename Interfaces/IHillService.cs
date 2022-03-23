using PracaInżynierskaTomaszBaczek.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInżynierskaTomaszBaczek.Interfaces
{
    public interface IHillService
    {
        public Task<string> CreateHill(UserInputModel model);
    }
}
