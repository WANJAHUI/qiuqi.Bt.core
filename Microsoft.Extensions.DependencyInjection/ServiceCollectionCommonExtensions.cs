using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

// Microsoft.Extensions.DependencyInjection.ServiceCollectionCommonExtensions
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionCommonExtensions
    {
        [CompilerGenerated]
        private sealed class Bt
        {
            public Type type;
            internal bool IsServiceType(ServiceDescriptor A_0)
            {
                return A_0.ServiceType == type;
            }
        }

        public static bool IsAdded<T>(this IServiceCollection services)
        {
            return services.IsAdded(typeof(T));
        }
        public static bool IsAdded(this IServiceCollection services, Type type)
        {
            bool result = default(bool);
            result = services.Any(delegate (ServiceDescriptor A_0)
            {
                return A_0.ServiceType == type;
            });
            return result;
        }
        public static T GetSingletonInstanceOrNull<T>(this IServiceCollection services)
        {
            T result = default(T);
            object obj = null;
            
            ServiceDescriptor? serviceDescriptor = services.FirstOrDefault(delegate (ServiceDescriptor A_0)
            {
                return A_0.ServiceType==typeof(T);
            });
            if (serviceDescriptor != null)
            {
                obj = serviceDescriptor!.ImplementationInstance;
                result = (T)obj;

            }
            return result;

        }
        public static T GetSingletonInstance<T>(this IServiceCollection services)
        {
            int a_ = 16;
            bool flag2 = default(bool);
            T val = default(T);
            bool flag = default(bool);
            T result = default(T);

            val = services.GetSingletonInstanceOrNull<T>();
            flag2 = val == null;
            
            if (flag2)
            {
                val = services.BuildServiceProvider().GetService<T>();
                flag = val == null;
                goto IL0503;
            }
            IL0503:
            if (!flag)
            {
                result = val;
                return result;
            }
            else
            {
                throw new Exception(ServiceCollectionRegistrationActionExtensions.b("뢧얉瀞馘䖂\udda8玃츬\uf6d5", a_) + typeof(T).AssemblyQualifiedName);
            }

        }

    }

}
