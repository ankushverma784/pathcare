﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pathcare.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult index()
        {
            return View();
        }
        public ActionResult index2()
        {
            return View();
        }
        public ActionResult service()
        {
            return View();
        }
        public ActionResult blog()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}