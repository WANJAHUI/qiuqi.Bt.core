using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt
{
    public class BtApplicationWithExternalServiceProvider : ApplicationBase
    {
        public BtApplicationWithExternalServiceProvider(Type startupModuleType, IServiceCollection services, List<Action<BtFrameworkCreateOptions>> options = null)
        {

        }
        }
}
