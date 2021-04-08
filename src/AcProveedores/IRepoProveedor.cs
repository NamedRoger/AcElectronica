using DatabasaeManager.Entidades;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcProveedores
{
    public interface IRepoProveedor : IRepo<Proveedor,int>
    {
    }
}
