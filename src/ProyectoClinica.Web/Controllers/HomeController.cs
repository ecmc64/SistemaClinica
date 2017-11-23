using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoClinica.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
    /*
     Mantenimientos
	Doctores
	Importar Doctores
Citas
	Programa de Atencion
	Reserva de cita
	Atención de Pacientes
Reportes
	Pacientes Atendidos
	Reporte de Citas Atendidas
     */
}
