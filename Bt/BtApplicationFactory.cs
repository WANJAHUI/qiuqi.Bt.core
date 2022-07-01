using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt
{
    public static class BtApplicationFactory
    {
        public static IBtApplicationWithExternalServiceProvider Create<TStartupModule>(IServiceCollection services, Action<BtFrameworkCreateOptions>[] options)
        {
            Type typeFromHandle = typeof(TStartupModule);
            IBtApplicationWithExternalServiceProvider result = new BtApplicationWithExternalServiceProvider(typeFromHandle, services, options?.ToList());
            return result;

        }

    }
}
