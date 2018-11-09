/*
 IS 403 Project 1 -- SnekWebsite
 Created by Team Snek -- Andrew Dale, Nate Turner, Matt Smith, and Chelsia Liu
 11/8/2018
 */

using SnekWebsite.Models;
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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page. Hello!";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(Contact_Info info)
        {
            if (ModelState.IsValid)
            {
                return View("Confirmation");
            }
            else
            {
                return View();
            }
            
        }
    }
}