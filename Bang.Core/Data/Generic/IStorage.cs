using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bang.Core.Data.Generic
{
    public interface IStorage<T>
    {
        void Create(T obj);
        T Read(string Id);
        void Update(T obj);
        void Delete(string Id);
        
    }
}
