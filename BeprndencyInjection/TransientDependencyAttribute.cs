using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt.core.BeprndencyInjection
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public  class TransientDependencyAttribute : Attribute
    {
    }
}
