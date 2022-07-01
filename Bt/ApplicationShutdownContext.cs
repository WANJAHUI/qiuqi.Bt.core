using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bt
{
    public class ApplicationShutdownContext
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private readonly IServiceProvider serviceProvider;
        public IServiceProvider ServiceProvider
        {
            get { return serviceProvider; } 
        }
        public ApplicationShutdownContext(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider; 
        }
    }
}
