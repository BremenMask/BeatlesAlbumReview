using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string ReviewerName { get; set; }
        public int Rating { get; set; }
        public string ReviewDate { get; set; }

        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }
    }
}
