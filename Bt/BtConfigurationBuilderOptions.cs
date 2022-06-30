using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bt
{
    public  class BtConfigurationBuilderOptions
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private List<JsonFileOptions> jsonFileOptionsList = new List<JsonFileOptions>();
        public List<JsonFileOptions> JsonFileOptionsList
        {
            get { return jsonFileOptionsList; }
            set { jsonFileOptionsList = value; }
        }


    }

}
