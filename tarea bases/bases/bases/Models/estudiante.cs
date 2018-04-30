using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Data.Entity;
namespace bases.Models
{
    public class estudiante
    {
        public int estudianteId { get; set; }
        public int carnet { get; set; }
        public string nombre { get; set; }
        public int idCarrera { get; set; }
        public DateTime fecha { get; set; }
        public string foto { get; set; }
        public string video { get; set; }
        public string cedula { get; set; }

    }
}