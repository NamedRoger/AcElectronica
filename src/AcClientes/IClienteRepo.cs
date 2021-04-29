using DatabasaeManager.Entidades;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcClientes
{
    public interface IClienteRepo : IRepo<Cliente, int>
    {
        Task<List<CategoriaOpcion>> GetCategoriaOpcions(string categoria);
    }
}
