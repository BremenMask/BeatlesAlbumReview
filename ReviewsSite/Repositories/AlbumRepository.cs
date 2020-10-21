using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class AlbumRepository : IRepository<Album>
    {
        private DiscographyContext db;
        public AlbumRepository(DiscographyContext db)
        {
            this.db = db;
        }

        public IEnumerable<Album> GetAll()
        {
            return db.Albums;
        }

        public Album GetById(int id)
        {
            return db.Albums.Single(c => c.Id == id);
        }

        public void Create(Album obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Album obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Album obj)
        {
            throw new NotImplementedException();
        }
    }
}
