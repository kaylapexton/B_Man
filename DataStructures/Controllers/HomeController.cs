using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructures.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //this is the stack place
        public ActionResult Stack()
        {


            return View();
        }

        //this is the Queue place
        public ActionResult Queue()
        {


            return View();
        }

        //this is the dictionary place
        public ActionResult Dictionary()
        {


            return View();
        }

        //this will exit (hopefully)
        public ActionResult Exit()
        {

            return View();
        }
    }
}