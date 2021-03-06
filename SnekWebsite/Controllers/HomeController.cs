﻿/*
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
        //Create list of snake objects.
        public List<Snake> liSnakes = new List<Snake>();

        public void AddSnakes()
        {
            liSnakes.Add(new Snake(1, "Artemis", "Nate", "Corn snake", "4 years", "This girl is sassy, but super sweet!", "URL"));
            liSnakes.Add(new Snake(2, "Athena", "Kelly", "Corn snake", "4 years", "This girl is soooo snuggly!", "URL"));
            liSnakes.Add(new Snake(3, "Midas", "Nate & Kelly", "Corn snake", "1 year", "Tiny, cute butter noodle.", "URL"));
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Snakes()
        {
            if (liSnakes.Count == 0)
            {
                AddSnakes();
            }
            ViewBag.SnakeList = liSnakes;

            return View();
        }

        public ActionResult ShowSnake(int id)
        {
            //Iterate through list to find matching snake.
            int iCount = 0;
            foreach(Snake snek in liSnakes)
            {
                iCount++;
                if(snek.snakeID == id)
                {
                    ViewBag.Snek = snek;
                    break;
                }
            }
            ViewBag.Count = iCount;

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