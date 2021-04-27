using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabasaeManager.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string ClaveRegistro { get; set; }//buscar
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
        public string Comentario { get; set; }
        public string Paqueteria { get; set; }//buscar
        public DateTime? FechaAlta { get; set; }

        public string Banco { get; set; }
        public string ClaveBancaria { get; set; }
        public string CuentaBancaria { get; set; }

        [Required]
        public string Representante { get; set; }//buscar
        public string EmpresaTelefeono { get; set; }// buscar
        [Required]
        public string EmpresaCelular { get; set; }// buscar
        public string EmpresaEmail { get; set; }//buscar 
        public string EmpresaDomicilio { get; set; }
        public string EmpresaCiudad { get; set; }// buscar
        public string EmpresaEstado { get; set; }
        public string EmpresaPais { get; set; }
        public string EmpresaCp { get; set; }

        public decimal DiasCredito { get; set; }

        public int IdCategoria { get; set; }
        public CategoriaOpcion Categoria { get; set; }
        public int IdNumeroPrecio { get; set; }
        public CategoriaOpcion NumeroPrecio { get; set; }

        public bool Activo { get; set; } = true;
    }
}
