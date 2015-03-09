using FinalAssign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalAssign.Controllers
{
    public class HomeController : Controller
    {
        public FinalAssignContext db = new FinalAssignContext();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View(db.Cities);
        }
    }
}
