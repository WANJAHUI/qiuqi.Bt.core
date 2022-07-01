using Bt.core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt
{
    public  class ModuleContext
    {
        private static List<IBtModuleDescriptor> btModuleDescriptors;
        public List<IBtModuleDescriptor> ModuleDescriptors { get { return btModuleDescriptors; }  set { btModuleDescriptors = value; } }  

    }
}
