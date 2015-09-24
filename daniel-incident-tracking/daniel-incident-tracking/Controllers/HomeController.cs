﻿using daniel_incident_tracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace daniel_incident_tracking.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Report
        public ActionResult Report()
        {
            Report one = new Report();
            return View(one);
        }

        // GET: Report
        [HttpPost]
        public ActionResult Report(Report newReport)
        {
            return Content("Received Username:" + newReport.name + "Location:" + newReport.location + "Incident:" + newReport.incident);
        }
    }
}