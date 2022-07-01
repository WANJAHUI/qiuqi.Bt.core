using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bt.core.Model
{
    public interface IOnApplicationInitialization
    {
        void OnApplicationInitialization(ApplicationInitializationContext context);
      
    }
}