using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabasaeManager.Entidades
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
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
        public bool Activo { get; set; } = true;

        public ICollection<Aplicacion> Aplicaciones { get; set; }
    }
}
