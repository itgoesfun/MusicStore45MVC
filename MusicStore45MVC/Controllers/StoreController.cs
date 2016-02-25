﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore45MVC.Models;

namespace MusicStore45MVC.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var genres = new List<Genre>
            {
                new Genre {Name = "Disco" },
                new Genre {Name = "Jazz" },
                new Genre {Name = "Rock" },
                new Genre {Name = "Country" }
            };
            return View(genres);
        }

        //for parameter we use? in url and HttpUtility.HtmlEncode();
        // GET: Store/Browse?genre=Disco  
        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name = genre };
            return View(genreModel);
        }

        // GET: Store/Details/5
        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id};
            return View(album); 
        }
    }
}