using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class AlbumController : Controller
    {
        public ViewResult Index()
        {
            AlbumRepository albumRepo = new AlbumRepository();

            var model = albumRepo.GetAll();

            return View(model);
        }
    }
}
