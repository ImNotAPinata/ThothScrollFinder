﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ThothScrollFinder.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Thoth was the egyptian god of wisdom";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}