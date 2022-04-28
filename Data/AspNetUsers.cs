using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using PracaInżynierskaTomaszBaczek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInżynierskaTomaszBaczek.Data
{
    public class AspNetUsers : IdentityUser
    {
        public string DisplayedUsername { get; set; }
        public virtual List<CreatedHills> Hills { get; set; }
    }
}
