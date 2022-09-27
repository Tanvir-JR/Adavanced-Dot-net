using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV_Write.Controllers
{
    public class HomeCVController : Controller
    {
        // GET: HomeCV
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Contact()
        { 

            return View();
        }
        public ActionResult Education()
        {

            return View();
        }
        public ActionResult Project()
        {

            return View();
        }
        public ActionResult Skill()
        {

            return View();
        }
    }
}