using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bt.DependencyInjection
{
    public  class ServiceRegistrationActionList : List<Action<IOnServiceRegistredContext>>
    {
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool _IsClassInterceptorsDisabled;
        public bool IsClassInterceptorsDisabled 
        {
            [CompilerGenerated]
            get { return _IsClassInterceptorsDisabled; }
            [CompilerGenerated]
            set { _IsClassInterceptorsDisabled = value; }
        
        }

    }
}
