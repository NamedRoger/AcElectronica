using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcUsuarios
{
    public interface IRepoUsuario<TEntidad> : IRepo<TEntidad,int>
    {
        Task<bool> HasApplication(int idUsuario,string app);
    }
}
