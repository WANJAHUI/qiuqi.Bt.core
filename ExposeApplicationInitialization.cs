using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt.core
{
    public interface ExposeApplicationInitialization
    {
        void GetApplicationInitializationContext(ApplicationInitializationContext A_0);

        void GetApplicationShutdownContext(ApplicationShutdownContext A_0);
    }
}
