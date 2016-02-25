using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MusicStore45MVC.Models;

namespace MusicStore45MVC.Controllers
{
    public class TabViewController : Controller
    {
        // GET: TabView
        public ActionResult Index()
        {
            return View();
        }

        //MusicStoreEntities db = new MusicStoreEntities();

        //public ActionResult Index()
        //{
        //    IList<Genre> genreList = new List<Genre>();
        //    //genreList = db.Genres.Add();
        //    //genreList = db.DbSet<Genre>.Add(Genres);
        //    return View(genreList);


        //IList<Product> productList = new List<Product>();
        //productList = (from m in db.Products select m).ToList<Product>();
        //return View(productList);
    //} 
     }
}