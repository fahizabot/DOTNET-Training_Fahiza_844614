using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class accountController : Controller
    {
        // GET: account
        public ActionResult signin ()
        {
            //string username = Request.QueryString["UN"];
            //       ViewBag.UName = username;
           // ViewBag.name = "";
            return View();
        }
        [HttpPost]
        //public ActionResult signin(string nm, string age)
        public ActionResult signin(userinfo info)//string nm,string age
        {
            string name = info.nm;
            name = "bonjour " + name + "ur age is" + info.age;
            ViewBag.name = name;
            //return View();
            //  return Redirect("/Home/Index");
            return RedirectToAction("showroles");
        }
        public ActionResult showroles()
        {
            return View();
        }

        public ActionResult process(string nm ,string age)
        {
            string name = nm;
            name = "bonjour " + name+ "ur age is"+age;
            ViewBag.name = name;
            return View();
        }
    }
}