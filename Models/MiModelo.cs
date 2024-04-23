using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using practicaMVC.Models;
using System.Collections.Generic;

namespace practicaMVC.Models
{
    using System.Text.Json;
    using Newtonsoft.Json;
    public class MiModelo
    {

        public List<Persona> LeerArchivoJson(string rutaArchivo)
        {
            string json = File.ReadAllText(rutaArchivo);
            Console.WriteLine("Archivo JSON encontrado");
            List<Persona> objetos = JsonConvert.DeserializeObject<List<Persona>>(json);
            Console.WriteLine("Objetos tipo persona encontrados");
            return objetos;
        }

    }
}


