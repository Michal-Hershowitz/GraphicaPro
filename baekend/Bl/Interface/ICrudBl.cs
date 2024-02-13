using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Interface
{
    public interface ICrudBl<T>
    {
        Task<List<T>> Get();
        Task<T> Get(string id);
        Task<T> Create(T addition);
        Task Update(string id, T addition);
        Task Remove(string id);
    }
}
