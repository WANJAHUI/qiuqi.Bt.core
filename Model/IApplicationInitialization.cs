using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bt.core.Model
{
    public interface IApplicationInitialization
    {
        void OnPreApplicationInitialization(ApplicationInitializationContext context);
        void OnApplicationInitialization(ApplicationInitializationContext context);
        void OnPostApplicationInitialization(ApplicationInitializationContext context);
    }
}