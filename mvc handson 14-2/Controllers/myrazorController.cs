using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class myrazorController : Controller
    {
        // GET: myrazor
        public ActionResult Index()
        {
           
           SelectListItem[] items=new SelectListItem[3];
            items[0] = new SelectListItem() { Text = "c#", Value = "0" };
            items[1] = new SelectListItem() { Text = "c++", Value = "1" };
            items[2] = new SelectListItem() { Text = "java", Value = "2" };
            ViewBag.dep = items;
            return View();
        }
            public ActionResult process(string rn,string lst,DateTime sd,DateTime ed)
            {
            handyEntities ra = new handyEntities();
            trmtable tt = new trmtable();
            tt.rname = rn;
            tt.skill = lst;
            tt.sdate = sd;
            tt.edate = ed;
            ra.trmtables.Add(tt);
            ra.SaveChanges();
                return View();
            }
        
    }
}