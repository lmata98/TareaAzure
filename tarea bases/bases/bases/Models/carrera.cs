using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Data.Entity;
namespace bases.Models
{
    public class carrera
    {

        public int carreraId { get; set; }
        public int idCarrera { get; set; }
        public string nombre { get; set; }
        public string encargado { get; set; }
        public string ubicacion { get; set; }
    }
}