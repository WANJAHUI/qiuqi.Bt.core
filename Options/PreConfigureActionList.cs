using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt.core.Options
{
    public  class PreConfigureActionList<TOptions>:List<Action<TOptions>>
    {
        public void Configure(TOptions options)
        {
            using (Enumerator enumerator = GetEnumerator())
            {
                if (enumerator.MoveNext())
                {
                    Action<TOptions> current = enumerator.Current;
                    current(options);
                    
                }
            }
        }
    }
}
