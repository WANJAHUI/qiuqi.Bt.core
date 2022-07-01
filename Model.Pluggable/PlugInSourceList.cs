using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt.core.Model.Pluggable
{
    public class PlugInSourceList : List<IPlugInSource>
    {
        internal IEnumerable<Type> GetModulesWithAllDependencies()
        {
            return this.SelectMany(delegate (IPlugInSource A_0)
            {
                return A_0.GetModulesWithAllDependencies();

            });
        }
    }
}
