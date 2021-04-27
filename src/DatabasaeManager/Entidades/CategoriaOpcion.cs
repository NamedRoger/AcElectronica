using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasaeManager.Entidades
{
    public class CategoriaOpcion
    {
        public int IdCategoriaOpcion { get; set; }
        public string Nombre { get; set; }
        public int IdCategoriaMenu { get; set; }
        public CategoriaMenu CategoriaMenu { get; set; }
    }
}
