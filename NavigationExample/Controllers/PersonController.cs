using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NavigationExample.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult PersonList()
        {
            return View();
        }
        public ActionResult PersonAdd()
        {
            return View();
        }
        public ActionResult PersonDelete()
        {
            return View();
        }

    }
}