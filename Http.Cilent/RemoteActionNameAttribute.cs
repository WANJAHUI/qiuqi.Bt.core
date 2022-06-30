using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bt.core.Http.Cilent
{
    [AttributeUsage(AttributeTargets.Method)]
    public class RemoteActionNameAttribute:Attribute
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private readonly string _actionName;
        public string ActionName
        {
            get { return _actionName; }
        }
        public RemoteActionNameAttribute(string actionName)
        {
            _actionName = actionName;
        }
    }
}
