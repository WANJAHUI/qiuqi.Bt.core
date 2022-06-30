using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt
{
    public  interface IBtApplicationWithExternalServiceProvider : IBtApplication,IDisposable
    {
        void SetServiceProvider([NotNull] IServiceProvider serviceProvider);

        void Initialize([NotNull] IServiceProvider serviceProvider);
    }
}
