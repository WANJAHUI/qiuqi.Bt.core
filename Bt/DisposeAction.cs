using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt
{
    public class DisposeAction : IDisposable
    {
        private readonly Action _dispose;
        public DisposeAction(Action action)
        {
            _dispose = action;
        }

        public void Dispose()
        {
            _dispose();
        }
    }
}
