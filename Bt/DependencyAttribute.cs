using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bt
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DependencyAttribute: Attribute
    {
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ServiceLifetime? lifetime;
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool isTryAddServices;
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool isReplaceServices;
        public virtual ServiceLifetime? Lifetime { [CompilerGenerated] get { return lifetime; } [CompilerGenerated] set { lifetime = value; } }
        public virtual bool IsTryAddServices{ [CompilerGenerated] get { return isTryAddServices; } [CompilerGenerated] set { isTryAddServices = value; } }
        public virtual bool IsReplaceServices { [CompilerGenerated] get { return isReplaceServices; } [CompilerGenerated] set { isReplaceServices = value; } }

        public DependencyAttribute()
        {
        }
        public DependencyAttribute(ServiceLifetime lifetime)
        {
            Lifetime = lifetime;
        }
        }
}
