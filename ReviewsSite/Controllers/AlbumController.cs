using ReviewsSite.Models;
using ReviewsSite.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class AlbumController : Controller
    {
        IRepository<Album> albumRepo;

        public AlbumController(IRepository<Album> albumRepo)
        {
            this.albumRepo = albumRepo;
        }

        public ViewResult Index()
        {
           //AlbumRepository albumRepo = new AlbumRepository();

            var model = albumRepo.GetAll();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = albumRepo.GetById(id);

            return View(model);
        }

        public ViewResult Reviews(int id)
        {
            var model = albumRepo.GetById(id);
            return View(model);
        }
    }
}
