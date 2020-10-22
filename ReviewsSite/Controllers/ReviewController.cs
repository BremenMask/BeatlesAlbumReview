using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<Review> reviewRepo;

        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult Index()
        {
            var model = reviewRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = reviewRepo.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpGet]
        public ViewResult CreateByAlbumId(int id)
        {
            ViewBag.AlbumId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Review review)
        {
            review.ReviewDate = DateTime.Now.ToString("MM/dd/yyyy");

            if (ModelState.IsValid)
            {
                reviewRepo.Create(review);
                return RedirectToAction("Reviews", "Album", new { id = review.AlbumId });
            }
            return View(review);
        }

        [HttpGet]
        public ViewResult Update(int id)
        {
            Review model = reviewRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Review review)
        {
            review.ReviewDate = DateTime.Now.ToString("MM/dd/yyyy");

            if (ModelState.IsValid)
            {
                reviewRepo.Update(review);
                return RedirectToAction("Index", "Review", new { id = review.Id });
            }
            return View();
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            Review model = reviewRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Review review)
        {
            int albumId = review.AlbumId;
            reviewRepo.Delete(review);
            return RedirectToAction("Index");
        }
    }
}
