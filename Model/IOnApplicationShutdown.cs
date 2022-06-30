using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bt.core.Model
{
    public interface IOnApplicationShutdown
    {
        void OnApplicationShutdown(ApplicationInitializationContext context);
    }
}