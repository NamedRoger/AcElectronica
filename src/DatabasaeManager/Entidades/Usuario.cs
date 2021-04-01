using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasaeManager.Entidades
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Curp { get; set; }
        public string Nss { get; set; }
        public string NumeroInfonavit { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Foto { get; set; }
    }
}
