using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class menuController : Controller
    {
        // GET: menu
      //  [ChildActionOnly]
        public ActionResult Index()
        {
            return View();
        }
       
    }
}