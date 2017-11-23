using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoClinica.Web.Controllers
{
    public class ProgramacionController : Controller
    {
        public ProgramacionController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProgramarAtencion()
        {
            return View();
        }
            
    }
}
