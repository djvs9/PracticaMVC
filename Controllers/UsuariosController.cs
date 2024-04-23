using Microsoft.AspNetCore.Mvc;
using practicaMVC.Models;
using System;

namespace practicaMVC.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListaUsuarios()
        {
            Console.WriteLine("Buscando archivo JSON");
            String rutaArchivoJson = "C:/Users/Janeth/source/repos/practicaMVC/practicaMVC/registros.json";
            MiModelo miModelo = new MiModelo();
            List<Persona> personas = miModelo.LeerArchivoJson(rutaArchivoJson);
            return View(personas);
        }

        [HttpPost]
        public IActionResult ListaUsuarios(string selUsuarios)
        {
            String rutaArchivoJson = "C:/Users/Janeth/source/repos/practicaMVC/practicaMVC/registros.json";
            MiModelo miModelo = new MiModelo();
            List<Persona> personas = miModelo.LeerArchivoJson(rutaArchivoJson);
            ViewBag.Nombre = selUsuarios;
            Console.WriteLine("Persona seleccionada: " + selUsuarios);
            return View(personas);

        }






    }
}
