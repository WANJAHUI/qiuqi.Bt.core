using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt.DependencyInjection
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public  class SingletonDependencyAttribute: Attribute
    {

    }
}
