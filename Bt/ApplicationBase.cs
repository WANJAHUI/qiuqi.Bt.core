using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt
{
    public class ApplicationBase : IBtApplication, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
