using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoClinica.Web.Controllers
{
    public class AtencionesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DetalleCita(int pIdCita)
        {
            return View();
        }
    
        public IActionResult GuardarDiagnostico()
        {

            return RedirectToAction("Index");
        }
    }
}
