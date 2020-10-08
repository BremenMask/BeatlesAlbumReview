using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
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
            Album album = new Album();

            return View(album);
        }
    }
}
