using Damacanawithdb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Damacanawithdb.Controllers
{
    public class ProductController : Controller
    { 
        db_damacanaEntities3 db = new db_damacanaEntities3();
        public ActionResult Index()
        {
            return View();
        }


      
       
        public ActionResult listproduct()
        {
            var liste = db.product.ToList();
            return View(liste);
        }

        public ActionResult addproduct(FormCollection Form)
        {
            product product = new product();
            product.name = Form["Name"];
            product.price = Form["Price"];
            return View(product);
        }
       [HttpPost]
        public ActionResult saveproduct(product product)
        {
            db.product.Add(product);
            db.SaveChanges();
            return View(product);
        }
       
 [HttpGet]
        public ActionResult deleteproduct(int id)
        {
            var product = db.product.Find(id);

            db.product.Remove(product);
            db.SaveChanges();


            return View();
        }


        [HttpGet]

        public ActionResult updateproduct(int id)
        {
            product product = new product();
            product.id = id;

            db.product.Remove(db.product.Find(id));
            db.SaveChanges();

            return View(product);
        }

        [HttpPost]
        public ActionResult saveupdate (product product, FormCollection Form)
        {

            product.name = Form["Name"];
            product.price = Form["Price"];
            db.product.Add(product);
            db.SaveChanges();

            return View(product);
        }

     
        public ActionResult addtocart(int id)
        {
            db.product.Find(id).cardId = 1;
            db.product.Find(id).number++;
            db.SaveChanges();


            return View();
        }

        public ActionResult removefromcart(string name)
        {
           // db.product.Find(name).cardId = 1;
            //db.product.Find(name).number--;
            db.SaveChanges();
            return View();
        }
    }
}