using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bang.Core.Data.Generic
{
    public interface IStorage<T>
    {
        void Create(T obj);
    }
}
