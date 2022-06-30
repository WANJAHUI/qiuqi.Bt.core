using Bt;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
// Microsoft.Extensions.DependencyInjection.ServiceCollectionConfigurationExtensions
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionConfigurationExtensions
    {
        public static IConfiguration GetConfiguration(this IServiceCollection services)
        {
            HostBuilderContext singletonInstanceOrNull = default(HostBuilderContext);
            singletonInstanceOrNull = services.GetSingletonInstanceOrNull<HostBuilderContext>();
            IConfiguration result = default(IConfiguration);
            bool flag = default(bool);
            object obj;
            if (singletonInstanceOrNull == null)
            {
                obj = null;
            }
            else
            {
                obj = singletonInstanceOrNull.Configuration;
            }
            flag = obj != null;
            if (!flag)
            {
                result = services.GetSingletonInstance<IConfiguration>();
                
            }
            else
            {
                result = singletonInstanceOrNull.Configuration as IConfigurationRoot;
            }
            return result;
        }
        public static void TryBuildConfiguration(this IServiceCollection services, BtFrameworkCreateOptions options, Action<IConfigurationBuilder> builderAction = null)
        {
            int a_ = 19;
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(ServiceCollectionRegistrationActionExtensions.b("\ua8c8믊뷌볎듐\ua7d2ꇔ뻖럘볚껜\uf1de诠郢諤触", a_), optional: true, reloadOnChange: true);
            List<JsonFileOptions>.Enumerator enumerator = options.BtConfigurationBuilderOptions.JsonFileOptionsList.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    JsonFileOptions current = enumerator.Current;
                    configurationBuilder.AddJsonFile(current.FileProvider, current.Path, current.Optional, current.ReloadOnChange);
                }
            }
            finally
            {
                ((IDisposable)enumerator).Dispose();
            }
            IConfiguration instance = configurationBuilder.Build();
            services.TryAddSingleton(instance);

        }
    }
}
