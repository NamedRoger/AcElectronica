using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabasaeManager.Entidades
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string ApodoProveedor { get; set; }//buscar
        [Required]
        public string RazonSocial { get; set; }// buscar
        public string Rfc { get; set; }// buscar
        [Required]
        public string Email { get; set; }//buscar
        [Required]
        public string Telefono { get; set; }//buscar
        public string Celular { get; set; }//buscar
        public string Domicilio { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Cp { get; set; }
        [Required]
        public string Notas { get; set; }
        public string Paqueteria { get; set; }//buscar
        public DateTime FechaAlta { get; set; }
        public DateTime UltimaCompra { get; set; }

        public string Banco { get; set; }
        public string ClaveBancaria { get; set; }
        public string CuentaBancaria { get; set; }

        public string Banco2 { get; set; }
        public string ClaveBancaria2 { get; set; }
        public string CuentaBancaria2 { get; set; }

        public string Banco3 { get; set; }
        public string ClaveBancaria3 { get; set; }
        public string CuentaBancaria3 { get; set; }

        [Required]
        public string Representante { get; set; }//buscar
        public string RepresentanteTelefeono { get; set; }// buscar
        [Required]
        public string RepresentanteCelular { get; set; }// buscar
        public string RepresentanteEmail { get; set; }//buscar 
        public string RepresentanteDomicilio { get; set; }
        public string RepresentanteCiudad { get; set; }// buscar
        public string RepresentanteEstado { get; set; }
        public string RepresentantePais { get; set; }
        public string RepresentatneCp { get; set; }

        public bool Activo { get; set; } = true;

    }
}
