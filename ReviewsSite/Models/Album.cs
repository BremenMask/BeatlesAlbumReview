using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Album
    {   
        public int Id { get; set; }
        public Album()
        {

        }

        public Album(int id)
        {
            Id = id;
        }
    }
}
