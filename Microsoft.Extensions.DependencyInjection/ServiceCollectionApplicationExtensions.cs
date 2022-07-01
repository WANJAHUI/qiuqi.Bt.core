using Autofac;
using Bt;
using Bt.core.Model;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Microsoft.Extensions.DependencyInjection.ServiceCollectionApplicationExtensions
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionApplicationExtensions
    {
        public static IBtApplicationWithExternalServiceProvider AddServiceEntrance<TStartupModule>(this IServiceCollection services, params Action<BtFrameworkCreateOptions>[] options) where TStartupModule : IBtModule
        {
            return BtApplicationFactory.Create<TStartupModule>(services, options);
        }
        public static IBtApplicationWithExternalServiceProvider AddServiceEntrance<TStartupModule>(this IServiceCollection services) where TStartupModule : IBtModule
        {
            return BtApplicationFactory.Create<TStartupModule>(services, (Action<BtFrameworkCreateOptions>[])null);
        }
        public static IServiceProvider BuildApplication<TStartupModule>(this IServiceCollection services, params Action<BtFrameworkCreateOptions>[] options) where TStartupModule : IBtModule
        {
            services.AddTransient<ILoggerFactory, LoggerFactory>();
            services.AddTransient(typeof(ILogger<>), typeof(Logger<>));
            IBtApplicationWithExternalServiceProvider aceApplicationWithExternalServiceProvider = services.AddServiceEntrance<TStartupModule>(options);
            IServiceProviderFactory<ContainerBuilder> singletonInstance = services.GetSingletonInstance<IServiceProviderFactory<ContainerBuilder>>();
            IServiceProvider serviceProvider = singletonInstance.CreateServiceProvider(singletonInstance.CreateBuilder(services));
            aceApplicationWithExternalServiceProvider.Initialize(serviceProvider);
            return aceApplicationWithExternalServiceProvider.ServiceProvider;

        }
        }
}
