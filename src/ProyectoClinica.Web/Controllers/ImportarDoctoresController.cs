﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoClinica.Web.Controllers
{
    public class ImportarDoctoresController : Controller
    {
        public ImportarDoctoresController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ImportarDoctores()
        {
            return RedirectToAction("Index");
        }
    }
}
