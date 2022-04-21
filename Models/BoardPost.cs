using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInżynierskaTomaszBaczek.Models
{
    public class BoardPost
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime PubDate { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
