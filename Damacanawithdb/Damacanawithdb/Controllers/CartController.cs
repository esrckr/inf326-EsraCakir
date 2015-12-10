using Damacanawithdb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Damacanawithdb.Controllers
{
    public class CartController : Controller
    {
        db_damacanaEntities3 db = new db_damacanaEntities3();
        public static List<product> products = new List<product>();
        public ActionResult Index()
        {
            return View();
        }




        public ActionResult listcart()
        {
            var liste = db.cart.ToList();
            return View(liste);
        }

      
        [HttpGet]
        public ActionResult listproductofcart()
        {
            


            return View(products);
        }
        public ActionResult detailcart()
        {
           

                foreach (product find in db.product)
            { if (find.cardId == 1)
                { foreach (product existe in products)
                    { if (existe.id != find.id) { }
                      break;
                    }
                }    products.Add(find);
            }
              return View(products);
            
        }
       
        public ActionResult removefromcart(string name)
        {
            foreach (var find in products)
            {
                if (find.name==name)
                { find.cardId = 0; db.product.Find(find.id).cardId = 0; db.product.Find(find.id).number--;
                }
                break;

            }
      
       
            return View(products);
        }




    }
}
