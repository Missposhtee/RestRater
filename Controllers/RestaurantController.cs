using RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantRater.Controllers
{
    public class RestaurantController : Controller
    {
        //GET: Restaurant
        private RestaurantDBContext db = new RestaurantDBContext();
        // GET: Restaurant
        public ActionResult Index()
        {
            return View(db.Restaurant.ToList());

        }
        //GET: Restaurant/Create
        public ActionResult Create()
        {

            return View(); 

            
        }
    }
}