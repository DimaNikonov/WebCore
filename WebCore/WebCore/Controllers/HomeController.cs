﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCore.Models;

namespace WebCore.Controllers
{
    public class HomeController : Controller
    {
        LogInfoContext context;
        public HomeController(LogInfoContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var table = context.logInfoes.ToList();
            return View(table);
        }
        
    }
}
