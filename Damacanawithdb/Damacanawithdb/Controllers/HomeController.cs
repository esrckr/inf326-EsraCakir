using Damacanawithdb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Damacanawithdb.Controllers
{
    public class HomeController : Controller
    {
        db_damacanaEntities3 db = new db_damacanaEntities3();
        public ActionResult Index()
        {
            
            
            return View();
            
        }
        [HttpPost]
        public ActionResult Access( FormCollection Form)
        {
            
            if ( Form["Name"] == "amy")
            { return View(); }
            return View();

        }

        public ActionResult About()
        {


            return View();

        }
    }
}