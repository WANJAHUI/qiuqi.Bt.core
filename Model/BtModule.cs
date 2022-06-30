using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Bt.core.Model
{
    public class BtModule : IBtModule ,IApplicationInitialization,IOnApplicationShutdown, IPreConfigureServices, IPostConfigureServices, IOnRouteInitialization
    {
        private ServiceConfigurationContext _serviceConfigurationContext;
        protected internal bool SkipAutoServiceRegistration { get; protected set; }
        protected internal ServiceConfigurationContext ServiceConfigurationContext
        {
            get
            {
                if (_serviceConfigurationContext == null)
                {
                    throw new Exception("ServiceConfigurationContext is only available in the ConfigureServices, BeforeConfigureServices and AfterConfigureServices methods.");
                }

                return _serviceConfigurationContext;
            }
            internal set
            {
                _serviceConfigurationContext = value;
            }
        }
        public virtual void PostConfigureServices(ServiceConfigurationContext context)
        {
        }
        public virtual void PreConfigureServices(ServiceConfigurationContext context)
        {
        }
        public virtual void ConfigureServices(ServiceConfigurationContext context)
        {
        }
        public virtual void OnApplicationInitialization(ApplicationInitializationContext context)
        {
        }
        public virtual void OnApplicationShutdown(ApplicationInitializationContext context)
        {
        }
        public virtual void OnPostApplicationInitialization(ApplicationInitializationContext context)
        {
        }
        public virtual void OnPreApplicationInitialization(ApplicationInitializationContext context)
        {
        }
        public virtual void OnRouteInitialization(RouteBuilderContext context)
        {

        }
        public static bool IsBtModule(Type type)
        {
            TypeInfo typeInfo = type.GetTypeInfo();
            return typeInfo.IsClass && !typeInfo.IsAbstract && !typeInfo.IsGenericType && typeof(IBtModule).GetTypeInfo().IsAssignableFrom(type);
        }
        internal static void IsBtType(Type moduleType)
        {
            if (!IsBtModule(moduleType))
            {
                throw new ArgumentException("Given type is not an Bt module: " + moduleType.AssemblyQualifiedName);
            }
        }
        protected void Configure<TOptions>(Action<TOptions> configureOptions) where TOptions : class
        {
            ServiceConfigurationContext.Services.Configure(configureOptions);
        }
        protected void Configure<TOptions>(string name, Action<TOptions> configureOptions) where TOptions : class
        {
            ServiceConfigurationContext.Services.Configure(name, configureOptions);
        }
        protected void Configure<TOptions>(IConfiguration configuration) where TOptions : class
        {
            ServiceConfigurationContext.Services.Configure<TOptions>(configuration);
        }
        protected void Configure<TOptions>(IConfiguration configuration, Action<BinderOptions> configureBinder) where TOptions : class
        {
            ServiceConfigurationContext.Services.Configure<TOptions>(configuration, configureBinder);
        }
        protected void Configure<TOptions>(string name, IConfiguration configuration) where TOptions : class
        {
            ServiceConfigurationContext.Services.Configure<TOptions>(name, configuration);
        }
        protected void PreConfigurl<TOptions>(Action<TOptions> configureOptions) where TOptions : class
        {
            ServiceConfigurationContext.Services.Configure<TOptions>(configureOptions);
        }
        protected void PostConfigure<TOptions>(Action<TOptions> configureOptions) where TOptions : class
        {
            ServiceConfigurationContext.Services.Configure<TOptions>(configureOptions);
        }
        protected void PostConfigureAll<TOptions>(Action<TOptions> configureOptions) where TOptions : class
        {
            ServiceConfigurationContext.Services.Configure<TOptions>(configureOptions);
        }
    }
}