﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LashmerAdmin.Models;
using LashmerAdmin.Models.DataModels;
using LashmerAdmin.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace LashmerAdmin.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //  if (User.Identity.IsAuthenticated)
        //  {
        //    return RedirectToAction("Index", "Order");
        //  }
        //  else
        //  {
        //    return Redirect("~/Identity/Account/Login");
        //  }
        //}

        public IActionResult Contact()
        {
          ViewData["Message"] = "Your contact page.";

          return View();
        }

        public IActionResult Privacy()
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
