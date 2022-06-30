using System;
using System.Collections;
using System.Collections.Generic;

namespace Bt.core.Collections
{
    public  interface ITypeList<in TBaseType>: IList<Type>, ICollection<Type>, IEnumerable<Type>, IEnumerable
    {
        void Add<T>() where T : TBaseType;

        bool TryAdd<T>() where T : TBaseType;

        bool Contains<T>() where T : TBaseType;

        void Remove<T>() where T : TBaseType;


    }
}
