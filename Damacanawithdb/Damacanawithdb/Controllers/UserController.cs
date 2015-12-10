using Damacanawithdb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Damacanawithdb.Controllers
{
    public class UserController : Controller
    {
        db_damacanaEntities3 db = new db_damacanaEntities3();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult listuser()
        {
            var liste = db.user.ToList();
            return View(liste);
        }

        public ActionResult adduser(FormCollection Form)
        {
            user user = new user();
            user.name = Form["Name"];
            return View(user);
        }
        [HttpPost]
        public ActionResult saveuser(user user)
        {
            db.user.Add(user);
            db.SaveChanges();
            return View(user);
        }

        [HttpGet]
        public ActionResult deleteuser(int id)
        {
            var user = db.user.Find(id);

            db.user.Remove(user);
            db.SaveChanges();


            return View();
        }



    }
}