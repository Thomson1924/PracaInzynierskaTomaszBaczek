using PracaInżynierskaTomaszBaczek.Data;
using System;

namespace PracaInżynierskaTomaszBaczek.Models
{
    public class CreatedHill
    {
        public int Id { get; set; }
        public virtual AspNetUsers User { get; set; }
        public string HillName { get; set; }
        public Guid guid { get; set; }
    }
}
