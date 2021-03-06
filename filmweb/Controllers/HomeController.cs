﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using filmweb.Models;
using filmweb.ViewModels;
using Microsoft.AspNetCore.Authorization;
using filmweb.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace filmweb.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext db;
        public HomeController(DataContext context)
        {
            db = context;
        }

        public IActionResult Index()
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
