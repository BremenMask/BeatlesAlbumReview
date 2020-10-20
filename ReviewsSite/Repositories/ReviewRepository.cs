using Microsoft.EntityFrameworkCore;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class ReviewRepository : IRepository<Review>
    {
        private DiscographyContext db;

        public ReviewRepository(DiscographyContext db)
        {
            this.db = db;
        }

        public IEnumerable<Review> GetAll()
        {
            return db.Reviews.Include("Album");
        }

        public Review GetById(int id)
        {
            return db.Reviews.Single(c => c.Id == id);
        }

        public void Create(Review review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
        }
    }
}
