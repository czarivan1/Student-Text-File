using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website_Project_Address.Controllers
{
    public class Default1Controller : Controller
    {
        //
        // GET: /Default1/
/*
        public ActionResult Index()
        {
            return View();
        }
*/
        // GET: Home
        public ActionResult Index()
        {
            masterEntities1 entities = new masterEntities1();
            //return View(from Customers in entities.Customers.Take(10)
            //          select customer);

            return View(from customers in entities.Customers.Take(50)
                        select customers);
        }

    }

}
