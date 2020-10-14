using Microsoft.EntityFrameworkCore;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public class AlbumContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
    }
}
