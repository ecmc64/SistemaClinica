using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoClinica.Web.Controllers
{
    public class DoctorController : Controller
    {
        public DoctorController()
        {

        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult ObtenterDoctor(int Id)
        {
            return View();
        }

        public IActionResult CrearDoctor()
        {
            return RedirectToAction("Index");
        }

        public IActionResult ActualizarDoctor()
        {
            return RedirectToAction("Index");
        }


    }
}
