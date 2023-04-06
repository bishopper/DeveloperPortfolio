﻿using DeveloperPortfolio_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeveloperPortfolio_MVC.Controllers
{
    public class HomeController : Controller
    { 
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}