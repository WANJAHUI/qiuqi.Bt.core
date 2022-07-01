using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bt
{
    public class NullDisposable : IDisposable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        private static readonly NullDisposable instance;
        public static NullDisposable Instance
        {
            [CompilerGenerated]
            get { return instance; }
        }
        private NullDisposable()
        {
        }
        static NullDisposable()
        {
            instance = new NullDisposable();
        }

            public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
