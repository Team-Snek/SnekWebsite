﻿/*
 IS 403 Project 1 -- SnekWebsite
 Created by Team Snek -- Andrew Dale, Nate Turner, Matt Smith, and Chelsia Liu
 11/8/2018
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SnekWebsite.Controllers
{
    public class HomeController : Controller
    {
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
    }
}