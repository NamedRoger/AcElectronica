using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface IRepo<TEndidad,TKey>
    {
        Task<IEnumerable<TEndidad>> GetAll();
        Task<TEndidad> Get(TKey key);
        Task Add(TEndidad endidad);
        Task Update(TKey key, TEndidad endidad);
        Task Delete(TKey key);
    }
}
