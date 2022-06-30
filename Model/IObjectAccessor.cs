using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt.core.Model
{
    public  interface IObjectAccessor<T>
    {
        T Value { get; }
    }
}
