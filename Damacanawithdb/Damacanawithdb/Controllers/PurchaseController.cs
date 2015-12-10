using Damacanawithdb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Damacanawithdb.Controllers
{
    public class PurchaseController : Controller
    {
        db_damacanaEntities3 db = new db_damacanaEntities3();
        public static List<product> products = new List<product>();
        // GET: Purchase
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult listpurchase()
        {
            var liste = db.purchase.ToList();
            return View(liste);
        }

        // GET: Purchase/Details/5
        public ActionResult addpurchase()
        {
            purchase purchase = new purchase();
            {
                purchase.createdon = DateTime.Now;
                purchase.id = 2;
            }

         decimal k = 0;

            foreach (var find in db.product)
            {

                if (find.cardId == 1)
                {

                    k=k+ Convert.ToDecimal( find.price);
                   purchase.product.Add(find);

                }

            }
            purchase.totalprice = k;
          
            return View();
       
        }
        [HttpPost]
        public ActionResult SavePurchase(purchase purchase)
        {   db.purchase.Add(purchase);
            db.SaveChanges();


            return View(purchase);
        }


        // GET: Purchase/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Purchase/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Purchase/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Purchase/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Purchase/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Purchase/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
