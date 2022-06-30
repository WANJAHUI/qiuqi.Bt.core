using Bt.core.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt.core.Model.Pluggable
{
    public  interface IPlugInSource
    {
        TypeList<IBtModule> GetModules();
    }
}
