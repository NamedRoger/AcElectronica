using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasaeManager.Entidades
{
    public class CategoriaMenu
    {
        public int IdCategoriaMenu { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<CategoriaOpcion> CategoriaOpcions { get; set; }
    }
}
