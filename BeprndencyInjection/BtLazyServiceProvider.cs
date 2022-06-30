using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bt.BeprndencyInjection
{
    public class BtLazyServiceProvider : IBtLazyServiceProvider, ITransientDependency
    {
        [CompilerGenerated]
        private sealed class RequiredService 
        {
            public BtLazyServiceProvider BtLazyServiceProvider;
            public Type ServiceType;
            internal object GetRequiredService()
            {
                return BtLazyServiceProvider.ServiceProvider.GetRequiredService(ServiceType);
            }
        }
        [CompilerGenerated]
        private sealed class Service
        {
            public BtLazyServiceProvider BtLazyServiceProvider;
            public Type ServiceType;
            internal object GetService()
            {
                return BtLazyServiceProvider.ServiceProvider.GetService(ServiceType);
            }
        }
        [CompilerGenerated]
        private sealed class FuncService
        {
            public Func<IServiceProvider, object> func;
            public BtLazyServiceProvider BtLazyServiceProvider;
            internal object GetIServiceProviderFunc()
            {
                return func(BtLazyServiceProvider.ServiceProvider);
            }

        }

        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IServiceProvider serviceProvider;
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IDictionary<Type, object> cachedServices;

        protected IDictionary<Type, object> CachedServices
        {
            get { return cachedServices; }
            set { cachedServices = value; } 
        }
        public IServiceProvider ServiceProvider
        {
            get { return serviceProvider; }
            set { serviceProvider = value; }
        }

        public BtLazyServiceProvider(IServiceScopeFactory serviceScopeFactory)
        {
            ServiceProvider = serviceScopeFactory.CreateScope().ServiceProvider;
            CachedServices = new Dictionary<Type,object>();
            
        }

        public T LazyGetRequiredService<T>()
        {
            return (T)LazyGetRequiredService(typeof(T));
            
        }

        public object LazyGetRequiredService(Type serviceType)
        {
           return CachedServices.GetOrAdd(serviceType, (Func<object>)delegate
            {
                return ServiceProvider.GetRequiredService(serviceType);
            });
            }

        public T LazyGetService<T>()
        {
            return (T)LazyGetService(typeof(T));
            
        }

        public object LazyGetService(Type serviceType)
        {
            return CachedServices.GetOrAdd(serviceType, (Func<object>)delegate
            {
                return ServiceProvider.GetService(serviceType);
            });
            }

        public T LazyGetService<T>(Func<IServiceProvider, object> factory)
        {
           return (T)LazyGetService<T>(factory);
        }

        public object LazyGetService(Type serviceType, Func<IServiceProvider, object> factory)
        {
            return CachedServices.GetOrAdd(serviceType, (Func<object>)delegate
            {
                return factory(ServiceProvider);
            });
            }
    }
}
