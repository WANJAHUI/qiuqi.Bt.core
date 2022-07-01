using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bt.DependencyInjection
{
    public class OnServiceRegistredContext : IOnServiceRegistredContext
    {
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Type serviceType;
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Type implementationType;
        public virtual Type ServiceType { get { return serviceType; } }
        public virtual Type ImplementationType { get { return implementationType; } }
        public OnServiceRegistredContext(Type serviceType, Type implementationType)
        {
            this.serviceType = serviceType;
            this.implementationType = implementationType;
        }
    }
}
