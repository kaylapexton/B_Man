using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMenus.Controllers
{
    public class StackController : Controller
    {
        static Stack<string> myStack = new Stack<string>();

        // GET: Stack
        public ActionResult Index()
        {
            ViewBag.MyStack = myStack;
            return View();
        }

        public ActionResult AddOne()
        {
            myStack.Push("new Entry " + (myStack.Count + 1));

            ViewBag.MyStack = myStack;

            return View("Index");
        }
    }
}