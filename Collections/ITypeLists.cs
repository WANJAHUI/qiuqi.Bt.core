using System;
using System.Collections;
using System.Collections.Generic;

namespace Bt.core.Collections
{
    public interface ITypeList : ITypeList<object>, IList<Type>, ICollection<Type>, IEnumerable<Type>, IEnumerable
    {
    }
}
