using Microsoft.AspNetCore.Components.Authorization;
using PracaInżynierskaTomaszBaczek.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInżynierskaTomaszBaczek.Interfaces
{
    public interface IHillEditorService
    {
        public Task<string> CreateHill(UserInputModel model, AuthenticationState authstate);
    }
}
