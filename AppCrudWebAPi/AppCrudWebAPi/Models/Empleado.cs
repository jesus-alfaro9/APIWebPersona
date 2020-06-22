using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppCrudWebAPi.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public DateTime FechaContratación { get; set; }
        public string Dirección { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string TelDomicilio { get; set; }

    }
}