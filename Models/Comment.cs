using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInżynierskaTomaszBaczek.Models
{
    public class Comment
    {
        public string Author { get; set; }
        public string Body { get; set; }
        public DateTime PubDate { get; set; }
    }
}
