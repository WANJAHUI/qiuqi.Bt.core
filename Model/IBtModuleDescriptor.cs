using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bt.core.Model
{
    public  interface IBtModuleDescriptor
    {
        Type Type { get; }

        Assembly Assembly { get; }

        IBtModule Instance { get; }

        bool IsLoadedAsPlugIn { get; }

        void AddRely(IBtModuleDescriptor relytor);
    }
}
